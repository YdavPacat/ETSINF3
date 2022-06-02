byte mutex=0;
mtype = {idle,entering,critical,exiting}

proctype P(){
mtype state;
    state=idle;
do
    :: state == idle -> state = idle;
    :: state == idle -> state = entering;
    :: (state == entering && mutex==0) ->
        mutex++;
        state = critical;
    :: state == critical ->
        mutex--;
        state = exiting;
    :: state == exiting -> state = idle;
od
}
    init{
    atomic { run P(); run P(); }
}
ltl security {[] (mutex < 2)}