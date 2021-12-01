// worcli
// invoked with "node worcli bk1URL bk2URL delay class"
// all 5 parameters are mandatory
var zmq = require('zeromq')
, rw = zmq.socket('req')
, rc = zmq.socket('req')

var args = process.argv.slice(2)
if (args.length < 4) {
  console.log ("Usage: node worcli bk1URL bk2URL transfer_delay class")
  console.log ("Redirects bk1’s class requests to bk2 broker, increasing delay ms")
  process.exit(-1)
}

var w2bk = args[0] // worcli connected to bk1 as a worker
var c2bk = args[1] // worcli connected to bk2 as a client
var myID  = "WC_"+require('os').hostname()
//myID = "W_"+Date.now()%100000
var delay = parseInt(args[2]) // transfer delay, in ms
var cid   = args[3]
var pendingClient

rw.identity = myID; rw.connect(w2bk)
rc.identity = myID; rc.connect(c2bk)

rw.on('message', (c,sep,m) => {
  pendingClient = c // only one waiting client, so we don't need a queue
  setTimeout(()=>{
	  rc.send([m, cid])}
	  , delay/2); // 50% forwarding
})

rw.send(['', cid])

rc.on('message', (m)=> {
  setTimeout(()=>{
    rw.send([pendingClient,'',m,cid])}
	, delay/2); // 50% returning
})
