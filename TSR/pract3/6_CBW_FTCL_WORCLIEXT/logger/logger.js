// logger in NodeJS
// First argument is port number for incoming messages
// Second argument is file path for appending log entries

var fs = require('fs');
var zmq = require('zeromq')
,   log = zmq.socket('pull')
var args = process.argv.slice(2);
if (args.length < 2) {
  console.log ("node logger loggerPort filename")
  process.exit(-1)
}

var loggerPort = args[0] // '9995'
var filename   = args[1] // "/tmp/cbwlog.txt"

log.bind('tcp://*:'+loggerPort);

log.on('message', function(text) {
  fs.appendFileSync(filename, text+'\n');
})
