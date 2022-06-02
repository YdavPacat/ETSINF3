bit turn=0;
int chosen=-1;

mtype:question = {nothing,requesting,finished};
mtype:question q2s[2];
mtype:server = {ungranted,granted};
mtype:server s2q[2];
mtype:state = {noanswer,request,answering,a,b,c,d}
mtype:state state[2];

proctype Pserver() {
  s2q[0]=ungranted;
  s2q[1]=ungranted;
  do
      :: atomic {
          (q2s[0] == requesting && q2s[1] != requesting && chosen == -1) ->
              chosen = 0; 
              s2q[0] = granted; 
              s2q[1] = ungranted; 
              q2s[0] = nothing;
              turn = 1;
          }
      :: atomic {
          (q2s[0] != requesting && q2s[1] == requesting && chosen == -1) ->
              chosen = 1; 
              s2q[1] = granted; 
              s2q[0] = ungranted; 
              q2s[1] = nothing;
              turn = 0;
          }
      :: atomic {
          (q2s[0] == requesting && q2s[1] == requesting && chosen == -1 && turn == 0) ->
              chosen = 0; 
              s2q[0] = granted; 
              s2q[1] = ungranted; 
              q2s[0] = nothing;
              turn = 1;
          }
      :: atomic {
          (q2s[0] == requesting && q2s[1] == requesting && chosen == -1 && turn == 1) ->
              chosen = 1; 
              s2q[1] = granted; 
              s2q[0] = ungranted; 
              q2s[1] = nothing;
              turn = 0;
          }

      :: atomic { q2s[0] == finished -> 
          chosen = -1;
          q2s[0] = nothing;
          s2q[0] = ungranted;
      }
      :: atomic { q2s[1] == finished -> 
          chosen = -1;
          q2s[1] = nothing;
          s2q[1] = ungranted;
      }
  od
}

proctype Q(bit i){
state[i]=noanswer;
q2s[i]=nothing;
do
    :: state[i] == noanswer -> state[i] = noanswer;
    :: atomic {
        (state[i] == noanswer && q2s[i] == nothing) ->
            state[i] = request;
            q2s[i] = requesting;
        }
    :: atomic {
        (state[i] == request && s2q[i] == granted) ->  
            {
              state[i] = answering;
              s2q[i] = ungranted;
              q2s[i] = nothing; 
            }
            
        }
    :: atomic {
        (state[i] == answering) ->
            q2s[i] == finished;
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
    atomic { run Q(0); run Q(1); run Pserver(); }
}

ltl security {[] !((state[0] == answering) && (state[1] == answering))}
ltl liveness0 {[] ((state[0] == request) -> (<> (state[0] == answering)))}
ltl liveness1 {[] ((state[1] == request) -> (<> (state[1] == answering)))}
