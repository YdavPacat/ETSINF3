const zmq = require('zeromq')
let pub = zmq.socket('pub')
let port = process.argv[2]
let numMensajes = process.argv[3]
let msg = process.argv.slice(4)
let contardor = 1;
pub.bind('tcp://*:' + port)

function emite() {
    let m=msg[0]

    let msgSend = `${contardor}: ${m} ${Math.floor((contardor - 1)/msg.length) + 1}`
    pub.send(msgSend)
    console.log(msgSend)

    msg.shift(); msg.push(m) //rotatorio
    
    if (contardor == numMensajes)
        process.exit();
    contardor++;
}
setInterval(emite,1000)