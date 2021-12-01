FROM tsr2021/ubuntu-zmq
COPY ./logger.js /mylogger.js
VOLUME /tmp/cbwlog
EXPOSE 9995
CMD node mylogger 9995 $LOGGER_DIR/logs
