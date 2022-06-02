	switch (t->back) {
	default: Uerror("bad return move");
	case  0: goto R999; /* nothing to undo */

		 /* CLAIM security */
;
		
	case 3: // STATE 1
		goto R999;

	case 4: // STATE 10
		;
		p_restor(II);
		;
		;
		goto R999;

		 /* PROC :init: */

	case 5: // STATE 1
		;
		;
		delproc(0, now._nr_pr-1);
		;
		goto R999;

	case 6: // STATE 2
		;
		;
		delproc(0, now._nr_pr-1);
		;
		goto R999;

	case 7: // STATE 4
		;
		p_restor(II);
		;
		;
		goto R999;

		 /* PROC P */

	case 8: // STATE 1
		;
		((P0 *)_this)->state = trpt->bup.oval;
		;
		goto R999;

	case 9: // STATE 3
		;
		((P0 *)_this)->state = trpt->bup.ovals[1];
	/* 0 */	((P0 *)_this)->state = trpt->bup.ovals[0];
		;
		;
		ungrab_ints(trpt->bup.ovals, 2);
		goto R999;

	case 10: // STATE 5
		;
		((P0 *)_this)->state = trpt->bup.ovals[1];
	/* 0 */	((P0 *)_this)->state = trpt->bup.ovals[0];
		;
		;
		ungrab_ints(trpt->bup.ovals, 2);
		goto R999;

	case 11: // STATE 6
		;
	/* 0 */	((P0 *)_this)->state = trpt->bup.oval;
		;
		;
		goto R999;

	case 12: // STATE 7
		;
		now.mutex = trpt->bup.oval;
		;
		goto R999;

	case 13: // STATE 8
		;
		((P0 *)_this)->state = trpt->bup.oval;
		;
		goto R999;

	case 14: // STATE 9
		;
	/* 0 */	((P0 *)_this)->state = trpt->bup.oval;
		;
		;
		goto R999;

	case 15: // STATE 10
		;
		now.mutex = trpt->bup.oval;
		;
		goto R999;

	case 16: // STATE 11
		;
		((P0 *)_this)->state = trpt->bup.oval;
		;
		goto R999;

	case 17: // STATE 13
		;
		((P0 *)_this)->state = trpt->bup.ovals[1];
	/* 0 */	((P0 *)_this)->state = trpt->bup.ovals[0];
		;
		;
		ungrab_ints(trpt->bup.ovals, 2);
		goto R999;

	case 18: // STATE 17
		;
		p_restor(II);
		;
		;
		goto R999;
	}

