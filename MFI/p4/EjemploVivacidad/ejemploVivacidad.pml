byte mutex=false;
mtype = {idle,entering,critical,exiting}
mtype state[2];

proctype P(bit i){
    state[i]=idle;
do
    :: state[i] == idle -> state[i] = idle;
    :: state[i] == idle -> state[i] = entering;
    :: atomic {
        (state[i] == entering && mutex==0) ->
            mutex++;
            state[i] = critical;
        }
    :: state[i] == critical ->
    atomic {
        mutex--;
        state[i] = exiting;
    }
    :: state[i] == exiting -> state[i] = idle;
od
}
init{
    atomic { run P(0); run P(1); }
}
ltl security {[] (mutex < 2)}
ltl liveness0 {[] ((state[0] == entering) -> (<> (state[0] == critical)))}
ltl liveness1 {[] ((state[1] == entering) -> (<> (state[1] == critical)))}