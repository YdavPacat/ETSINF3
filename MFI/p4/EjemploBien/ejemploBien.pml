byte mutex=false;
mtype = {idle,entering,critical,exiting}

proctype P(){
mtype state;
    state=idle;
do
    :: state == idle -> state = idle;
    :: state == idle -> state = entering;
    :: atomic {
        (state == entering && mutex==0) ->
        mutex++;
        state = critical;
    }
    :: state == critical ->
    atomic {
        mutex--;
        state = exiting;
    }
    :: state == exiting -> state = idle;
od
}

init{
    atomic { run P(); run P(); }
}
ltl security {[] (mutex < 2)}