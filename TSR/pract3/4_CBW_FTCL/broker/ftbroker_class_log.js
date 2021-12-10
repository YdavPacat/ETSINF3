// ROUTER-ROUTER request-reply broker in NodeJS.
// Work classes. Logger variant
// Worker availability-aware variant.
//
// As code grows, complexity increases. This version returns to the
// original structure with auxiliar functions (sendToWorker & sendRequest)

var zmq = require('zeromq')
, sc    = zmq.socket('router')
, sw    = zmq.socket('router')
, sl    = zmq.socket('push')
, util  = require('util')

var args = process.argv.slice(2)
if (args.length < 3) {
  console.log ("node mybroker clientsPort workersPort loggerURL")
  process.exit(-1)
}

var cport = args[0]
var wport = args[1]
var lURL  = args[2]

const ansInterval = 2000
var workers = [], clients = [] // clients[] +-== who{}
var busyWks = [] // busy workers
					  // busyWks[] +-== tout{}

var myID = "B_"+require('os').hostname() // unused
//myID = "B_"+Date.now()%100000 // running without own IP

function testQueues(cid) {
	if (workers[cid]==undefined) {
	  workers[cid]=[]; clients[cid]=[]
	}
}
function annotate(prefix, id, cid) {
  var str=util.format(prefix+' %s (class "%s")', id, cid)
  //console.log(str)
  sl.send(str)
}

function annotate2(prefix, id, cid) {
  var str=util.format(prefix+' %s (class "%s")', id, cid)
  sl.send(str)
}

sc.bind('tcp://*:'+cport)
sw.bind('tcp://*:'+wport)
sl.connect(lURL)
annotate('CONNECTED', '', '')

// Send a message to a worker.
function sendToWorker(msg, cid) {
  var myWk = msg[0]
  annotate('TO Worker', myWk, cid)
  sw.send(msg)
  busyWks[myWk] = {}
  busyWks[myWk].cid = cid
  busyWks[myWk].msg = msg.slice(2)
  busyWks[myWk].timeout =
    setTimeout(newToutHandler(myWk),ansInterval)
}

// Function that sends a message to a worker, or
// holds the message if no worker is available now.
// Parameter 'args' is an array of message segments.
function sendRequest(args, cid) { // (c,sep,m,cid)
  if (workers[cid].length > 0) {
    var myWk = workers[cid].shift()
    var m = [myWk,''].concat(args)
	 annotate('UNQUEUEING Worker', myWk, cid)
    sendToWorker(m, cid)
  } else {
	 annotate('QUEUEING Client', args[0], cid)
    clients[cid].push({id: args[0],msg: args.slice(2)})
  }
}

function newToutHandler(wkID) {
  annotate('TOUT HANDLER', wkID, '')
  return () => {
    var msg = busyWks[wkID].msg
    var cid = busyWks[wkID].cid
    delete busyWks[wkID]
    annotate('TOUT EXPIRED', wkID, cid)
    sendRequest(msg, cid)
  }
}

sc.on('message', function() { // (c,sep,m,cid)
  var args = Array.apply(null, arguments)
  var cid  = args.pop()
  testQueues(cid)
  annotate('FROM Client', args[0], cid)
  sendRequest(args, cid) // (c,sep,m,cid)
});

function processPendingClient(wkID, cid) {
  if (clients[cid].length>0) {
    var nextClient = clients[cid].shift()
    var msg = [wkID,'',nextClient.id,''].concat(nextClient.msg)
    sendToWorker(msg, cid)
    return true
  } else return false
}

sw.on('message', function() { // (w,sep,c,sep2,r,cid)
  var args = Array.apply(null, arguments);
  var cid = args.pop()
  if (args.length == 3) {// if (c=='') -> (w,sep,'',cid)
	 testQueues(cid)
	 annotate('REGISTERING Worker', args[0], cid)
    if (!processPendingClient(args[0],cid)) {      
      annotate('QUEUEING Worker', args[0], cid)
      workers[cid].push(args[0])
    //return
    }
  } else {
      var wkID = args[0]
      // Check whether this worker timeout has been already deleted.
      // If so, the worker is considered faulty by this broker and no
      // response from it should be accepted.
      if (!busyWks[wkID]) {
      	annotate('DISCARDING late answer from Worker', wkID, cid)
      	return
      }
      clearTimeout(busyWks[wkID].timeout)
      args = args.slice(2)
      annotate('TO Client', args[0], cid)
      sc.send(args)
      if (!processPendingClient(wkID,cid)) {
        annotate('QUEUEING Worker', wkID, cid)
        workers[cid].push(wkID)
    }
  }
})
