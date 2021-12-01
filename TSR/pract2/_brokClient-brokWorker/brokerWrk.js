const zmq = require('zeromq')
const portBackend = process.argv[2] || '8002'
const portBroker1 = process.argv[3] || 'tcp://localhost:8001'

let workers=[]
let sb1 = zmq.socket('dealer') // broker1
let sw = zmq.socket('router') // backend

sb1.connect(portBroker1)
sw.bind('tcp://*:' + portBackend)


sb1.on('message', (c,sep2,m) =>{
    sw.send([workers.shift(),'',c,'',m])
})

sw.on('message',(w,sep,c,sep2,r)=> {
    workers.push(w); 
    sb1.send([c,'',r])
})