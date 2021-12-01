const zmq = require('zeromq')
let sub = zmq.socket('sub')
sub.connect('tcp://127.0.0.1:8000')
sub.subscribe('')
sub.on('message', (m) =>
{console.log('',m+'')})