const zmq = require('zeromq')
let req = zmq.socket('req');

var args = process.argv.slice(2)
if (args.length < 1) {
  console.log ("node myclient brokerURL")
  process.exit(-1)
}
var bkURL   = args[0]
var msgReceived = 0;
console.log(bkURL)
req.connect(bkURL)
// req.connect("tcp://localhost:" + bkURL)
req.on('message', (msg)=> {
	msgReceived++;	
	console.log('resp'+ msgReceived + ': '+msg)

	if (msgReceived == 10)
		process.exit(0);
})

for (var i = 0; i < 10; i++)
	req.send('Hola')
