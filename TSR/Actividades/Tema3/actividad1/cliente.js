var zmq = require('zeromq') 
var rq = zmq.socket('req') 
rq.connect('tcp://127.0.0.1:8888') 
var i = 0;
function envia (msg){
   return () => rq.send(msg + i++)  
}

setInterval(envia('Hello'), 1000)

rq.on('message', function(msg) {   
     console.log('Response: ' + msg) 
})