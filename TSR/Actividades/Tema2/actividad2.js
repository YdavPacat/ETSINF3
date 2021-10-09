const ev = require('events')
const emitter = new ev.EventEmitter
const e1 = "print"
const e2 = "read"
const books = [ "Walk Me Home", "When I Found You", "Jane's Melody", "Pulse" ]

// Constructor for class Listener.
function Listener(n1,n2) {
    this.num1 = 0
    this.name1 = n1
    this.num2 = 0
    this.name2 = n2
}
Listener.prototype.event1 = function() {
    this.num1++
    console.log( "Event " + this.name1 + " has happened " + this.num1 + " times." )
}
Listener.prototype.event2 = function(a) {
    console.log( "Event " + this.name2 + " (with arg: " + a + ") has happened " +
    ++this.num2 + " times." )
}
// A Listener object is created.
const lis = new Listener(e1,e2)

// Listener is registered on the event emitter.
emitter.on(e1, function() {lis.event1()})
emitter.on(e2, function(x) {lis.event2(x)})

// There might be more than one listener for the same event.
emitter.on(e1, function() {console.log("Something has been printed!!");})

// Auxiliary function for generating e2.
let counter=0;
function generateEvent2() {
    // This second argument provides the argument for the "e2" listener.
    emitter.emit(e2,books[counter++ % books.length])
}

// Generate the events periodically...
// First event generated every 2 seconds.
setInterval( function() {
    emitter.emit(e1)
}, 2000 )

// Second event generated every 3 seconds.
setInterval( generateEvent2, 3000 )
