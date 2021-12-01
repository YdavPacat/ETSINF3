const zmq = require('zeromq')
let req = zmq.socket('req')
req.identity = 'Worker1'

var args = process.argv.slice(2)
if (args.length < 1) {
  console.log ("node myclient brokerURL")
  process.exit(-1)
}
var bkURL   = args[0]
req.connect(bkURL)
req.on('message', (c,sep,msg)=> {
	setTimeout(()=> {
		req.send([c,'','resp'])
	}, 1000)
})
req.send(['','',''])
