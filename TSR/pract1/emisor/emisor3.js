const ev = require('events')
const emitter = new ev.EventEmitter()

const e1='e1', e2='e2'
let inc=0, t
function rand() { // debe devolver valores aleat en rango [2000,5000) (ms)
  // Math.floor(x) devuelve la parte entera del valor x
  // Math.random() devuelve un valor en el rango [0,1)
  let res = 2000;
  let random = Math.floor(Math.random() * 3000);
  return res + random;

}
function handler (e,n) { // e es el evento, n el valor asociado
 return (inc) => {
   n += inc 
   console.log(e + '-->' + n)
   
 } // el oyente recibe un valor (inc)
}
emitter.on(e1, handler(e1,0))
emitter.on(e2, handler(e2,''))
function etapa() {
    emitter.emit(e1, inc)
    emitter.emit(e2, inc)
    console.log(`Duración: ${t}`)
    inc++;
    setTimeout(etapa,t=rand())
}
setTimeout(etapa,t=rand())
