const urlFrontend = process.argv[2] || 'tcp://localhost:8000'
const nickClient = process.argv[3] || 'C1'
const txtPeticion = process.argv[4] || 'Hello'
const zmq = require('zeromq')

let req = zmq.socket('req');

req.identity = nickClient
req.connect(urlFrontend)

req.on('message', (msg)=> {
    console.log('resp: '+msg)
    process.exit(0);
})

req.send(txtPeticion)