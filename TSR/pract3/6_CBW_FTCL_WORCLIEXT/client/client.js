// client in NodeJS, classID must be provided as a parameter
// 10 messages and exit!
// CMD node myclient $BROKER_URL $CLASSID

const zmq = require('zeromq')
let req = zmq.socket('req')

var args = process.argv.slice(2)
if (args.length < 2) {
  console.log ("node myclient brokerURL class")
  process.exit(-1)
}
var bkURL   = args[0]
var cid     = args[1]
var nMsgs = 10
var myMsg   = 'Hello'
var myID    = "C_"+require('os').hostname()
//myID = "C_"+Date.now()%100000 // running without own IP

req.identity = myID
req.connect(bkURL)

req.on('message', (msg) => {
  if (--nMsgs == 0) process.exit(0)
  else req.send([myMsg,cid])
})

req.send([myMsg,cid])
