// Server 
var zmq = require('zeromq') 
var rp = zmq.socket('rep')  
rp.bind('tcp://127.0.0.1:8888',function(err) {  
      if (err) throw err })  

let numMensaje = 0;
rp.on('message', function(msg) {    
    if (numMensaje == 10) process.exit()
    numMensaje++;
    console.log('Request: ' + msg)   
    rp.send('World') 
})