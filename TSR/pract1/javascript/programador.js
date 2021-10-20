
const Proxy_IP = process.argv[2]
const Remote_IP = process.argv[3]
const Remote_PORT = process.argv[4]
const net = require('net');
const client = net.connect({port:8001},
    function() { //connect listener
        console.log('client connected');
        var msg = JSON.stringify ({'remote_ip':Remote_IP, 'remote_port':Remote_PORT})
        client.write(msg);
    });
client.on('data',
 function(data) {
        console.log(data.toString());
        client.end(); //no more data written to the stream
        
    });
client.on('end',
        function() {
        console.log('client disconnected');
    });