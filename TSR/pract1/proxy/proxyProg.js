const net = require('net');
const LOCAL_PORT = 8000;
const LOCAL_IP = '127.0.0.1';
let REMOTE_PORT;
let REMOTE_IP; 
const server = net.createServer(function (socket) {
    const serviceSocket = new net.Socket();
    serviceSocket.connect(parseInt(REMOTE_PORT), REMOTE_IP, function () {
            socket.on('data', function (msg) {
                serviceSocket.write(msg);
            });
            serviceSocket.on('data', function (data) {
                socket.write(data);
            });
    });
}).listen(LOCAL_PORT, LOCAL_IP);

const programer = net.createServer(
    function(c) { //connection listener
        console.log('server: programer connected');
        c.on('end',
        function() {
            console.log('server: programer disconnected');
            console.log(`REMOTE_IP = ${REMOTE_IP} || REMOTE_PORT = ${REMOTE_PORT}`);
        });
        c.on('data',
        function(data) {
            let json = JSON.parse(data)
            REMOTE_IP = json.remote_ip
            REMOTE_PORT = json.remote_port
            c.write(`Cambiando Remote IP a ${REMOTE_IP} y Remote PORT a ${REMOTE_PORT}`); // send resp
            c.end(); // close socket
        });
    });

programer.listen(8001,
    function() { //listening listener
        console.log('server bound');
    });

console.log("TCP server accepting connection on port: " + LOCAL_PORT);