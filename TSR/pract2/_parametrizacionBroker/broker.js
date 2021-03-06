const zmq = require('zeromq')
const portFrontend = process.argv[2] || '9998'
const portBackend = process.argv[3] || '9999'
let cli=[], req=[], workers=[]
let sc = zmq.socket('router') // frontend
let sw = zmq.socket('router') // backend
let peticionCount = 0;
let workersCount = {}
sc.bind('tcp://*:' + portFrontend)
sw.bind('tcp://*:' + portBackend)
sc.on('message',(c,sep,m)=> {
    if (workers.length==0) { 
        cli.push(c); req.push(m)
    } else {
        sw.send([workers.shift(),'',c,'',m])
    }
})
sw.on('message',(w,sep,c,sep2,r)=> {
    if (c=='') {workers.push(w); return}
    if (cli.length>0) { 
        sw.send([w,'',
            cli.shift(),'',req.shift()])
    } else {
        workers.push(w)
    }

    if (workersCount[w]) {
        workersCount[w]++
    }
    else{
        workersCount[w] = 1
    }
    ++peticionCount
    let algo = ' ' + peticionCount
    sc.send([c,'',r + algo])
})

setInterval(() =>{ 
    console.log("Numero de peticiones totales: " + peticionCount)
    for(const w in workersCount){
        console.log("\t-El " + w + " ha realizado " + workersCount[w] + " peticiones")
    }
    console.log()
}, 5000)