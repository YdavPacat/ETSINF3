const ev = require('events')
let emitter = new ev.EventEmitter

const uno = 'uno', dos = 'dos', tres = 'tres';

let n1 = 0, n2 = 0;
let d2 = 2000, i2

emitter.on(uno, () => {n1++; console.log(`Listener activo: ${n1}  eventos de tipo ${uno}`)})
emitter.on(dos, () => {n2++; console.log(n2>n1?`Evento ${dos}`:`hay más eventos de tipo ${uno}`)})
emitter.on(tres, () => {
    console.log(`Evento ${tres}`)
    if (d2 < 18000){ d2 *= 3; clearInterval(i2); i2 = setInterval(()=> emitter.emit(dos), d2)}
})

     setInterval(()=> emitter.emit(uno), 3000)
i2 = setInterval(()=> emitter.emit(dos), d2)
     setInterval(()=> emitter.emit(tres), 10000)