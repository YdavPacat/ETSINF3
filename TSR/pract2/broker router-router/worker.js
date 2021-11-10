const zmq = require('zeromq')
const urlBackend = process.argv[2]
const nickWorker = process.argv[3]
const txtRespuesta = process.argv[4]
let req = zmq.socket('req')
req.identity= nickWorker
req.connect(urlBackend)
req.on('message', (c,sep,msg)=> {
	setTimeout(()=> {
		req.send([c,'',txtRespuesta])
	}, 1000)
})
req.send(['','',''])
