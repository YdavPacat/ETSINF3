FROM tsr2021/ubuntu-zmq
#COPY ./ftbroker_class_log-funciona.js /mybroker.js
COPY ./ftbroker_class_log.js /mybroker.js
EXPOSE 9998 9999
CMD node mybroker $BROKERCL_PORT $BROKERW_PORT $LOGGER_URL
