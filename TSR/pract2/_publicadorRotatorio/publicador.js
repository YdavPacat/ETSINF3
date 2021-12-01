const zmq = require('zeromq')
let pub = zmq.socket('pub')
const port = process.argv[2]
let numMensajes = process.argv[3]
let msg = process.argv.slice(4)
let contardor = 1;
let contardorTema = {};
pub.bind('tcp://*:' + port)

function emite() {
    let m = msg[0]
    let m2 

    if (contardorTema[m]){
        contardorTema[m]++
    }else {
        contardorTema[m] = 1
    }
    
    m2 = m + ' ' + contardorTema[m]
    let msgSend = `${contardor}: ${m2}`
    pub.send(msgSend)
    console.log(msgSend)

    msg.shift(); msg.push(m) //rotatorio
    
    if (contardor == numMensajes)
        process.exit();
    contardor++;
}
setInterval(emite,1000)