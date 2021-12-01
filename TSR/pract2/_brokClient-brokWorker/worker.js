const zmq = require('zeromq')
const urlBackend = process.argv[2] || 'tcp://localhost:8002'
const nickWorker = process.argv[3] || 'W1'
const txtRespuesta = process.argv[4] || 'Resp1'

let req = zmq.socket('req')
req.identity= nickWorker
req.connect(urlBackend)

req.on('message', (c,sep,msg)=> {
    setTimeout(()=> {
        req.send([c,'',txtRespuesta])
        console.log(c + ' ' + msg  )
    }, 1000)
})

req.send(['','',''])
 