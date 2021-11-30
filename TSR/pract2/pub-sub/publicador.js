const zmq = require('zeromq')
let pub = zmq.socket('pub')
const port = process.argv[2]
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

--------------------------------------------------------------------------------------------------
Solución alternativa: 

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
