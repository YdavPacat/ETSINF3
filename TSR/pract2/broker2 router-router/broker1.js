const zmq = require('zeromq')
const portFrontend = process.argv[2]
const portBroker2 = process.argv[3]
const nickBroker = process.argv[4]

let cli=[], req=[], nworkers=0;
let sc = zmq.socket('router') // frontend
let sb2 = zmq.socket('dealer') // broker2

sb2.identity = nickBroker;
sc.bind('tcp://*:' + portFrontend)
sb2.bind('tcp://*:' + portBroker2)

sc.on('message',(c,sep,m)=> {
    if (nworkers == 0) { 
        cli.push(c); req.push(m)
    } else {
        sb2.send([c,'',m])
        nworkers--;
    }
})

sb2.on('message',(c,sep2,r)=> {
    console.log("Mensaje del Broker2")
    if(c==''){
        ++nworkers;
        console.log("nuevo worker")
        return
    }
    if (cli.length>0){
        sb2.send([cli.shift(),'',req.shift()])
        console.log()
	}else{
        ++nworkers;
    }
	sc.send([c,'',r])
})
