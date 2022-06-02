	switch (t->back) {
	default: Uerror("bad return move");
	case  0: goto R999; /* nothing to undo */

		 /* CLAIM liveness1 */
;
		;
		;
		;
		
	case 5: // STATE 13
		;
		p_restor(II);
		;
		;
		goto R999;

		 /* CLAIM liveness0 */
;
		;
		;
		;
		
	case 8: // STATE 13
		;
		p_restor(II);
		;
		;
		goto R999;

		 /* CLAIM security */
;
		
	case 9: // STATE 1
		goto R999;

	case 10: // STATE 10
		;
		p_restor(II);
		;
		;
		goto R999;

		 /* PROC :init: */

	case 11: // STATE 1
		;
		;
		delproc(0, now._nr_pr-1);
		;
		goto R999;

	case 12: // STATE 2
		;
		;
		delproc(0, now._nr_pr-1);
		;
		goto R999;

	case 13: // STATE 4
		;
		p_restor(II);
		;
		;
		goto R999;

		 /* PROC Q */

	case 14: // STATE 1
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.oval;
		;
		goto R999;

	case 15: // STATE 4
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.ovals[1];
		now.turn = trpt->bup.ovals[0];
		;
		ungrab_ints(trpt->bup.ovals, 2);
		goto R999;
;
		;
		
	case 17: // STATE 7
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.oval;
		;
		goto R999;

	case 18: // STATE 11
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.ovals[2];
		now.mutex = trpt->bup.ovals[1];
		now.turn = trpt->bup.ovals[0];
		;
		ungrab_ints(trpt->bup.ovals, 3);
		goto R999;
;
		;
		
	case 20: // STATE 14
		;
		now.mutex = trpt->bup.oval;
		;
		goto R999;

	case 21: // STATE 15
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.oval;
		;
		goto R999;
;
		
	case 22: // STATE 20
		goto R999;

	case 23: // STATE 16
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.oval;
		;
		goto R999;

	case 24: // STATE 17
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.oval;
		;
		goto R999;

	case 25: // STATE 18
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.oval;
		;
		goto R999;
;
		;
		
	case 27: // STATE 23
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.oval;
		;
		goto R999;

	case 28: // STATE 26
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.ovals[1];
		now.turn = trpt->bup.ovals[0];
		;
		ungrab_ints(trpt->bup.ovals, 2);
		goto R999;
;
		;
		
	case 30: // STATE 29
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.oval;
		;
		goto R999;

	case 31: // STATE 32
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.ovals[1];
		now.turn = trpt->bup.ovals[0];
		;
		ungrab_ints(trpt->bup.ovals, 2);
		goto R999;
;
		;
		
	case 33: // STATE 35
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.oval;
		;
		goto R999;

	case 34: // STATE 38
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.ovals[1];
		now.turn = trpt->bup.ovals[0];
		;
		ungrab_ints(trpt->bup.ovals, 2);
		goto R999;
;
		;
		
	case 36: // STATE 41
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.oval;
		;
		goto R999;

	case 37: // STATE 44
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.ovals[1];
		now.turn = trpt->bup.ovals[0];
		;
		ungrab_ints(trpt->bup.ovals, 2);
		goto R999;

	case 38: // STATE 49
		;
		p_restor(II);
		;
		;
		goto R999;
	}

