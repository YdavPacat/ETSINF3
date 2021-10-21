const net = require('net');

if (process.argv.length < 4){
    console.log("Error de argumentos")
    return;
}
const IP_servidor = process.argv[2];  
const IP_local = process.argv[3];
const client = net.connect({port:8002, host: IP_servidor},
    function() { //connect listener
        console.log('client connected');
        client.write('world!\r\n');
        
    });
client.on('data',
 function(data) {
        console.log(data + '');
        client.end(); //no more data written to the stream
        
    });
client.on('end',
        function() {
        console.log('client disconnected');
    });