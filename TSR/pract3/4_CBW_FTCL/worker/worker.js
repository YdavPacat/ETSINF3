// worker server in NodeJS, classID must be provided as a parameter
// 1.0 sec service, infinite loop!
// CMD node myworker $BROKER_URL $CLASSID

const zmq = require('zeromq')
let req   = zmq.socket('req')

const Tcpu = 1000
var replyText = "Done!" 
var args = process.argv.slice(2)
if (args.length < 2) {
  console.log ("node myworker brokerURL class")
  process.exit(-1)
}
var bkURL = args[0]
var cid   = args[1]
var myID  = "W_"+require('os').hostname()
//myID = "W_"+Date.now()%100000

req.identity = myID
req.connect(bkURL)

req.on('message', (c, sep, msg) => {
  setTimeout(() => {
      req.send([c,'',replyText,cid])
  }, Tcpu)
})

req.send(['',cid])
