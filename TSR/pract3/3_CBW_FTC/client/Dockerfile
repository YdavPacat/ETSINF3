FROM tsr2021/ubuntu-zmq
COPY ./client.js /myclient.js
# We assume that each client is linked to the broker
# container.
CMD node myclient $BROKER_URL $CLASSID
