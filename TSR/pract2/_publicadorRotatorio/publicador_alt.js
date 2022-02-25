const zmq = require('zeromq')
let pub = zmq.socket('pub')
let port = process.argv[2] 
let numMensajes = process.argv[3] 
let args = process.argv.slice(4)
let count = 1

pub.bind('tcp://*:' + port)

let i = 0

function emite() {
    i++
    let v = args[0] 
    let m='Tras ' + i + ' segundos: '+ i + ': ' + v + ' ' + count 
    pub.send(m)
    console.log(m)
    args.shift(); args.push(v) //rotatorio
    if (i%args.length == 0) ++count
    if (i == numMensajes) process.exit()
}

setInterval(emite,1000) // every second