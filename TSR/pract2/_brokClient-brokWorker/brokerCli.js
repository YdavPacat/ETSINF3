const zmq = require('zeromq')
const portFrontend = process.argv[2] || '8000'
const portBroker2 = process.argv[3] || '8001'

let cli=[], req=[], nworkers=0;
let sc = zmq.socket('router') // frontend
let del = zmq.socket('dealer') // broker2

sc.bind('tcp://*:' + portFrontend)
del.bind('tcp://*:' + portBroker2)

sc.on('message',(c,sep,m)=> {
    if (nworkers == 0) { 
        cli.push(c); req.push(m)
    } else {
        del.send([c,'',m])
        nworkers--;
    }
})

del.on('message',(c,sep2,r)=> {
    if(c==''){
        ++nworkers;
        return
    }
    if (cli.length>0){
        del.send([cli.shift(),'',req.shift()])
        console.log()
	}else{
        ++nworkers;
    }
	sc.send([c,'',r])
})