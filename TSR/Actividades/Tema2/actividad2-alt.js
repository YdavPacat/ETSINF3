const ev = require('events')
const emitter = new ev.EventEmitter

const e1 = 'print' , e2 = 'read'
const books = ['book0', 'book1', 'book2']


let n1 = 0, n2 = 0
emitter.on(e1, () => {console.log(`Event ${e1} has happend ${++n1} times`)})
emitter.on(e1, () => {console.log(`Something can be printed`)})
emitter.on(e2, (a) => {console.log(`Event ${e2} (with arg: ${a}) has happened ${++n2} times`)})

let counter = 0
setInterval(()=>emitter.emit(e1), 2000)
setInterval(()=>emitter.emit(e2, books[counter++%books.length]), 3000)