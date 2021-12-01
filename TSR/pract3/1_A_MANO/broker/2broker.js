const zmq = require('zeromq')
let sc = zmq.socket('router') // frontend
let sw = zmq.socket('router') // backend

var args = process.argv.slice(2)
if (args.length < 2) {
  console.log ("node mybroker clientsPort workersPort")
  process.exit(-1)
}

var cport = args[0]
var wport = args[1]
let cli=[], req=[], workers=[]
sc.bind('tcp://*:'+cport)
sw.bind('tcp://*:'+wport)
sc.on('message',(c,sep,m)=> {
	if (workers.length==0) { 
		cli.push(c); req.push(m)
	} else {
		sw.send([workers.shift(),'',c,'',m])
	}
})
sw.on('message',(w,sep,c,sep2,r)=> {
    if (c!='') sc.send([c,'',r])
	if (cli.length>0) { 
		sw.send([w,'',
			cli.shift(),'',req.shift()])
	} else {
		workers.push(w)
	}	
})
