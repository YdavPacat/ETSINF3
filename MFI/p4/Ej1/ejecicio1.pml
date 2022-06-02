byte mutex=0;
mtype:state = {noanswer,request,answering,a,b,c,d}
mtype:state state[2];
proctype Q(bit i){
    state[i] = noanswer;
do
    :: state[i] == noanswer -> state[i] = noanswer;
    :: state[i] == noanswer -> state[i] = request;
    :: atomic {
        (state[i] == request && mutex == 0) ->
            mutex++;
            state[i] = answering;
        }
    :: state[i] == answering ->
        atomic {
            mutex--;
            if
            :: state[i] = a;
            :: state[i] = b;
            :: state[i] = c;
            :: state[i] = d;
            fi
        }
    :: state[i] == a -> state[i] = noanswer;
    :: state[i] == b -> state[i] = noanswer;
    :: state[i] == c -> state[i] = noanswer;
    :: state[i] == d -> state[i] = noanswer;
od
}
init{
    atomic { run Q(0); run Q(1); }
}

ltl security {[] (mutex < 2)}
ltl liveness0 {[] ((state[0] == request) -> (<> (state[0] == answering)))}
ltl liveness1 {[] ((state[1] == request) -> (<> (state[1] == answering)))}