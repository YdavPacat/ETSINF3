byte mutex=0;
bit turn=0;
mtype:state = {noanswer,request,answering,a,b,c,d}
mtype:state state[2];
proctype Q(bit i){
    state[i] = noanswer;
do
    :: atomic {
        (state[i] == noanswer && turn == i) ->
            turn = (turn+1)%2;
            state[i] = noanswer;
    }
    :: state[i] == noanswer -> state[i] = request;
    :: atomic {
        (state[i] == request && mutex == 0 && turn == i) ->
            turn = (turn+1)%2;
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
    :: atomic {
        (state[i] == a && turn == i) ->
            turn = (turn+1)%2;
            state[i] = a;
    }
    :: state[i] == b -> state[i] = noanswer;
    :: atomic {
        (state[i] == b && turn == i) ->
            turn = (turn+1)%2;
            state[i] = b;
    }
    :: state[i] == c -> state[i] = noanswer;
    :: atomic {
        (state[i] == b && turn == i) ->
            turn = (turn+1)%2;
            state[i] = c;
    }
    :: state[i] == d -> state[i] = noanswer;
    :: atomic {
        (state[i] == a && turn == i) ->
            turn = (turn+1)%2;
            state[i] = d;
    }
od
}
init{
    atomic { run Q(0); run Q(1); }
}

ltl security {[] (mutex < 2)}
ltl liveness0 {[] ((state[0] == request) -> (<> (state[0] == answering)))}
ltl liveness1 {[] ((state[1] == request) -> (<> (state[1] == answering)))}