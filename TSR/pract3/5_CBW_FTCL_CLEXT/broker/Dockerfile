FROM tsr2021/ubuntu-zmq
#COPY ./ftbroker_class_log-funciona.js /mybroker.js
COPY ./ftbroker_class_log.js /mybroker.js
EXPOSE 9998 9999
CMD node mybroker 9998 9999 $LOGGER_URL
