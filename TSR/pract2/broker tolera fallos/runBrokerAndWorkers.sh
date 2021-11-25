echo "Sin toleracia a fallos"
node broker & node worker tcp://localhost:9999 W1 Resp1 &  node worker tcp://localhost:9999 W2 Resp2 & node worker tcp://localhost:9999 W1 Resp3 &
node client tcp://localhost:9998 C1 Hello  & node client tcp://localhost:9998 C2 World  & node client tcp://localhost:9998 C3 !  &
kill  node client tcp://localhost:9998 C1 Hello
sleep 5