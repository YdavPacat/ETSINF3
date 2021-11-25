const urlFrontend = process.argv[2]
const nickClient = process.argv[3]
const txtPeticion = process.argv[4]
const zmq = require('zeromq')
let req = zmq.socket('req');
req.identity = nickClient
req.connect(urlFrontend)
req.on('message', (msg)=> {
	console.log('resp: '+msg)
	process.exit(0);
})
req.send(txtPeticion)
