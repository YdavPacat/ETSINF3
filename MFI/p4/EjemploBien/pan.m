#define rand	pan_rand
#define pthread_equal(a,b)	((a)==(b))
#if defined(HAS_CODE) && defined(VERBOSE)
	#ifdef BFS_PAR
		bfs_printf("Pr: %d Tr: %d\n", II, t->forw);
	#else
		cpu_printf("Pr: %d Tr: %d\n", II, t->forw);
	#endif
#endif
	switch (t->forw) {
	default: Uerror("bad forward move");
	case 0:	/* if without executable clauses */
		continue;
	case 1: /* generic 'goto' or 'skip' */
		IfNotBlocked
		_m = 3; goto P999;
	case 2: /* generic 'else' */
		IfNotBlocked
		if (trpt->o_pm&1) continue;
		_m = 3; goto P999;

		 /* CLAIM security */
	case 3: // STATE 1 - _spin_nvr.tmp:3 - [(!((mutex<2)))] (6:0:0 - 1)
		
#if defined(VERI) && !defined(NP)
#if NCLAIMS>1
		{	static int reported1 = 0;
			if (verbose && !reported1)
			{	int nn = (int) ((Pclaim *)pptr(0))->_n;
				printf("depth %ld: Claim %s (%d), state %d (line %d)\n",
					depth, procname[spin_c_typ[nn]], nn, (int) ((Pclaim *)pptr(0))->_p, src_claim[ (int) ((Pclaim *)pptr(0))->_p ]);
				reported1 = 1;
				fflush(stdout);
		}	}
#else
		{	static int reported1 = 0;
			if (verbose && !reported1)
			{	printf("depth %d: Claim, state %d (line %d)\n",
					(int) depth, (int) ((Pclaim *)pptr(0))->_p, src_claim[ (int) ((Pclaim *)pptr(0))->_p ]);
				reported1 = 1;
				fflush(stdout);
		}	}
#endif
#endif
		reached[2][1] = 1;
		if (!( !((((int)now.mutex)<2))))
			continue;
		/* merge: assert(!(!((mutex<2))))(0, 2, 6) */
		reached[2][2] = 1;
		spin_assert( !( !((((int)now.mutex)<2))), " !( !((mutex<2)))", II, tt, t);
		/* merge: .(goto)(0, 7, 6) */
		reached[2][7] = 1;
		;
		_m = 3; goto P999; /* 2 */
	case 4: // STATE 10 - _spin_nvr.tmp:8 - [-end-] (0:0:0 - 1)
		
#if defined(VERI) && !defined(NP)
#if NCLAIMS>1
		{	static int reported10 = 0;
			if (verbose && !reported10)
			{	int nn = (int) ((Pclaim *)pptr(0))->_n;
				printf("depth %ld: Claim %s (%d), state %d (line %d)\n",
					depth, procname[spin_c_typ[nn]], nn, (int) ((Pclaim *)pptr(0))->_p, src_claim[ (int) ((Pclaim *)pptr(0))->_p ]);
				reported10 = 1;
				fflush(stdout);
		}	}
#else
		{	static int reported10 = 0;
			if (verbose && !reported10)
			{	printf("depth %d: Claim, state %d (line %d)\n",
					(int) depth, (int) ((Pclaim *)pptr(0))->_p, src_claim[ (int) ((Pclaim *)pptr(0))->_p ]);
				reported10 = 1;
				fflush(stdout);
		}	}
#endif
#endif
		reached[2][10] = 1;
		if (!delproc(1, II)) continue;
		_m = 3; goto P999; /* 0 */

		 /* PROC :init: */
	case 5: // STATE 1 - ejemploBien.pml:25 - [(run P())] (0:0:0 - 1)
		IfNotBlocked
		reached[1][1] = 1;
		if (!(addproc(II, 1, 0)))
			continue;
		_m = 3; goto P999; /* 0 */
	case 6: // STATE 2 - ejemploBien.pml:25 - [(run P())] (0:0:0 - 1)
		IfNotBlocked
		reached[1][2] = 1;
		if (!(addproc(II, 1, 0)))
			continue;
		_m = 3; goto P999; /* 0 */
	case 7: // STATE 4 - ejemploBien.pml:26 - [-end-] (0:0:0 - 1)
		IfNotBlocked
		reached[1][4] = 1;
		if (!delproc(1, II)) continue;
		_m = 3; goto P999; /* 0 */

		 /* PROC P */
	case 8: // STATE 1 - ejemploBien.pml:6 - [state = idle] (0:0:1 - 1)
		IfNotBlocked
		reached[0][1] = 1;
		(trpt+1)->bup.oval = ((P0 *)_this)->state;
		((P0 *)_this)->state = 4;
#ifdef VAR_RANGES
		logval("P:state", ((P0 *)_this)->state);
#endif
		;
		_m = 3; goto P999; /* 0 */
	case 9: // STATE 2 - ejemploBien.pml:8 - [((state==idle))] (16:0:2 - 1)
		IfNotBlocked
		reached[0][2] = 1;
		if (!((((P0 *)_this)->state==4)))
			continue;
		if (TstOnly) return 1; /* TT */
		/* dead 1: state */  (trpt+1)->bup.ovals = grab_ints(2);
		(trpt+1)->bup.ovals[0] = ((P0 *)_this)->state;
#ifdef HAS_CODE
		if (!readtrail)
#endif
			((P0 *)_this)->state = 0;
		/* merge: state = idle(0, 3, 16) */
		reached[0][3] = 1;
		(trpt+1)->bup.ovals[1] = ((P0 *)_this)->state;
		((P0 *)_this)->state = 4;
#ifdef VAR_RANGES
		logval("P:state", ((P0 *)_this)->state);
#endif
		;
		/* merge: .(goto)(0, 17, 16) */
		reached[0][17] = 1;
		;
		_m = 3; goto P999; /* 2 */
	case 10: // STATE 4 - ejemploBien.pml:9 - [((state==idle))] (16:0:2 - 1)
		IfNotBlocked
		reached[0][4] = 1;
		if (!((((P0 *)_this)->state==4)))
			continue;
		if (TstOnly) return 1; /* TT */
		/* dead 1: state */  (trpt+1)->bup.ovals = grab_ints(2);
		(trpt+1)->bup.ovals[0] = ((P0 *)_this)->state;
#ifdef HAS_CODE
		if (!readtrail)
#endif
			((P0 *)_this)->state = 0;
		/* merge: state = entering(0, 5, 16) */
		reached[0][5] = 1;
		(trpt+1)->bup.ovals[1] = ((P0 *)_this)->state;
		((P0 *)_this)->state = 3;
#ifdef VAR_RANGES
		logval("P:state", ((P0 *)_this)->state);
#endif
		;
		/* merge: .(goto)(0, 17, 16) */
		reached[0][17] = 1;
		;
		_m = 3; goto P999; /* 2 */
	case 11: // STATE 6 - ejemploBien.pml:11 - [(((state==entering)&&(mutex==0)))] (16:0:3 - 1)
		IfNotBlocked
		reached[0][6] = 1;
		if (!(((((P0 *)_this)->state==3)&&(((int)now.mutex)==0))))
			continue;
		if (TstOnly) return 1; /* TT */
		/* dead 1: state */  (trpt+1)->bup.ovals = grab_ints(3);
		(trpt+1)->bup.ovals[0] = ((P0 *)_this)->state;
#ifdef HAS_CODE
		if (!readtrail)
#endif
			((P0 *)_this)->state = 0;
		/* merge: mutex = (mutex+1)(16, 7, 16) */
		reached[0][7] = 1;
		(trpt+1)->bup.ovals[1] = ((int)now.mutex);
		now.mutex = (((int)now.mutex)+1);
#ifdef VAR_RANGES
		logval("mutex", ((int)now.mutex));
#endif
		;
		/* merge: state = critical(16, 8, 16) */
		reached[0][8] = 1;
		(trpt+1)->bup.ovals[2] = ((P0 *)_this)->state;
		((P0 *)_this)->state = 2;
#ifdef VAR_RANGES
		logval("P:state", ((P0 *)_this)->state);
#endif
		;
		/* merge: .(goto)(0, 17, 16) */
		reached[0][17] = 1;
		;
		_m = 3; goto P999; /* 3 */
	case 12: // STATE 10 - ejemploBien.pml:15 - [((state==critical))] (0:0:1 - 1)
		IfNotBlocked
		reached[0][10] = 1;
		if (!((((P0 *)_this)->state==2)))
			continue;
		if (TstOnly) return 1; /* TT */
		/* dead 1: state */  (trpt+1)->bup.oval = ((P0 *)_this)->state;
#ifdef HAS_CODE
		if (!readtrail)
#endif
			((P0 *)_this)->state = 0;
		_m = 3; goto P999; /* 0 */
	case 13: // STATE 11 - ejemploBien.pml:17 - [mutex = (mutex-1)] (0:16:2 - 1)
		IfNotBlocked
		reached[0][11] = 1;
		(trpt+1)->bup.ovals = grab_ints(2);
		(trpt+1)->bup.ovals[0] = ((int)now.mutex);
		now.mutex = (((int)now.mutex)-1);
#ifdef VAR_RANGES
		logval("mutex", ((int)now.mutex));
#endif
		;
		/* merge: state = exiting(16, 12, 16) */
		reached[0][12] = 1;
		(trpt+1)->bup.ovals[1] = ((P0 *)_this)->state;
		((P0 *)_this)->state = 1;
#ifdef VAR_RANGES
		logval("P:state", ((P0 *)_this)->state);
#endif
		;
		/* merge: .(goto)(0, 17, 16) */
		reached[0][17] = 1;
		;
		_m = 3; goto P999; /* 2 */
	case 14: // STATE 14 - ejemploBien.pml:20 - [((state==exiting))] (16:0:2 - 1)
		IfNotBlocked
		reached[0][14] = 1;
		if (!((((P0 *)_this)->state==1)))
			continue;
		if (TstOnly) return 1; /* TT */
		/* dead 1: state */  (trpt+1)->bup.ovals = grab_ints(2);
		(trpt+1)->bup.ovals[0] = ((P0 *)_this)->state;
#ifdef HAS_CODE
		if (!readtrail)
#endif
			((P0 *)_this)->state = 0;
		/* merge: state = idle(0, 15, 16) */
		reached[0][15] = 1;
		(trpt+1)->bup.ovals[1] = ((P0 *)_this)->state;
		((P0 *)_this)->state = 4;
#ifdef VAR_RANGES
		logval("P:state", ((P0 *)_this)->state);
#endif
		;
		/* merge: .(goto)(0, 17, 16) */
		reached[0][17] = 1;
		;
		_m = 3; goto P999; /* 2 */
	case 15: // STATE 19 - ejemploBien.pml:22 - [-end-] (0:0:0 - 1)
		IfNotBlocked
		reached[0][19] = 1;
		if (!delproc(1, II)) continue;
		_m = 3; goto P999; /* 0 */
	case  _T5:	/* np_ */
		if (!((!(trpt->o_pm&4) && !(trpt->tau&128))))
			continue;
		/* else fall through */
	case  _T2:	/* true */
		_m = 3; goto P999;
#undef rand
	}

