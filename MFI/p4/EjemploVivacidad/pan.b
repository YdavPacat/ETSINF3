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

		 /* PROC P */

	case 14: // STATE 1
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.oval;
		;
		goto R999;
;
		;
		
	case 16: // STATE 3
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.oval;
		;
		goto R999;
;
		;
		
	case 18: // STATE 5
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.oval;
		;
		goto R999;

	case 19: // STATE 8
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.ovals[1];
		now.mutex = trpt->bup.ovals[0];
		;
		ungrab_ints(trpt->bup.ovals, 2);
		goto R999;
;
		;
		
	case 21: // STATE 12
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.ovals[1];
		now.mutex = trpt->bup.ovals[0];
		;
		ungrab_ints(trpt->bup.ovals, 2);
		goto R999;
;
		;
		
	case 23: // STATE 15
		;
		now.state[ Index(((P0 *)_this)->i, 2) ] = trpt->bup.oval;
		;
		goto R999;

	case 24: // STATE 19
		;
		p_restor(II);
		;
		;
		goto R999;
	}

