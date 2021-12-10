FROM tsr2021/ubuntu-zmq
COPY ./worker.js /myworker.js
# We assume that each worker is linked to the broker
# container.
CMD node myworker $BROKER_URL $CLASSID
