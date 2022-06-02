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
	case 5: // STATE 1 - ejemolo.pml:20 - [(run P())] (0:0:0 - 1)
		IfNotBlocked
		reached[1][1] = 1;
		if (!(addproc(II, 1, 0)))
			continue;
		_m = 3; goto P999; /* 0 */
	case 6: // STATE 2 - ejemolo.pml:20 - [(run P())] (0:0:0 - 1)
		IfNotBlocked
		reached[1][2] = 1;
		if (!(addproc(II, 1, 0)))
			continue;
		_m = 3; goto P999; /* 0 */
	case 7: // STATE 4 - ejemolo.pml:21 - [-end-] (0:0:0 - 1)
		IfNotBlocked
		reached[1][4] = 1;
		if (!delproc(1, II)) continue;
		_m = 3; goto P999; /* 0 */

		 /* PROC P */
	case 8: // STATE 1 - ejemolo.pml:6 - [state = idle] (0:0:1 - 1)
		IfNotBlocked
		reached[0][1] = 1;
		(trpt+1)->bup.oval = ((P0 *)_this)->state;
		((P0 *)_this)->state = 4;
#ifdef VAR_RANGES
		logval("P:state", ((P0 *)_this)->state);
#endif
		;
		_m = 3; goto P999; /* 0 */
	case 9: // STATE 2 - ejemolo.pml:8 - [((state==idle))] (14:0:2 - 1)
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
		/* merge: state = idle(0, 3, 14) */
		reached[0][3] = 1;
		(trpt+1)->bup.ovals[1] = ((P0 *)_this)->state;
		((P0 *)_this)->state = 4;
#ifdef VAR_RANGES
		logval("P:state", ((P0 *)_this)->state);
#endif
		;
		/* merge: .(goto)(0, 15, 14) */
		reached[0][15] = 1;
		;
		_m = 3; goto P999; /* 2 */
	case 10: // STATE 4 - ejemolo.pml:9 - [((state==idle))] (14:0:2 - 1)
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
		/* merge: state = entering(0, 5, 14) */
		reached[0][5] = 1;
		(trpt+1)->bup.ovals[1] = ((P0 *)_this)->state;
		((P0 *)_this)->state = 3;
#ifdef VAR_RANGES
		logval("P:state", ((P0 *)_this)->state);
#endif
		;
		/* merge: .(goto)(0, 15, 14) */
		reached[0][15] = 1;
		;
		_m = 3; goto P999; /* 2 */
	case 11: // STATE 6 - ejemolo.pml:10 - [(((state==entering)&&(mutex==0)))] (0:0:1 - 1)
		IfNotBlocked
		reached[0][6] = 1;
		if (!(((((P0 *)_this)->state==3)&&(((int)now.mutex)==0))))
			continue;
		if (TstOnly) return 1; /* TT */
		/* dead 1: state */  (trpt+1)->bup.oval = ((P0 *)_this)->state;
#ifdef HAS_CODE
		if (!readtrail)
#endif
			((P0 *)_this)->state = 0;
		_m = 3; goto P999; /* 0 */
	case 12: // STATE 7 - ejemolo.pml:11 - [mutex = (mutex+1)] (0:0:1 - 1)
		IfNotBlocked
		reached[0][7] = 1;
		(trpt+1)->bup.oval = ((int)now.mutex);
		now.mutex = (((int)now.mutex)+1);
#ifdef VAR_RANGES
		logval("mutex", ((int)now.mutex));
#endif
		;
		_m = 3; goto P999; /* 0 */
	case 13: // STATE 8 - ejemolo.pml:12 - [state = critical] (0:0:1 - 1)
		IfNotBlocked
		reached[0][8] = 1;
		(trpt+1)->bup.oval = ((P0 *)_this)->state;
		((P0 *)_this)->state = 2;
#ifdef VAR_RANGES
		logval("P:state", ((P0 *)_this)->state);
#endif
		;
		_m = 3; goto P999; /* 0 */
	case 14: // STATE 9 - ejemolo.pml:13 - [((state==critical))] (0:0:1 - 1)
		IfNotBlocked
		reached[0][9] = 1;
		if (!((((P0 *)_this)->state==2)))
			continue;
		if (TstOnly) return 1; /* TT */
		/* dead 1: state */  (trpt+1)->bup.oval = ((P0 *)_this)->state;
#ifdef HAS_CODE
		if (!readtrail)
#endif
			((P0 *)_this)->state = 0;
		_m = 3; goto P999; /* 0 */
	case 15: // STATE 10 - ejemolo.pml:14 - [mutex = (mutex-1)] (0:0:1 - 1)
		IfNotBlocked
		reached[0][10] = 1;
		(trpt+1)->bup.oval = ((int)now.mutex);
		now.mutex = (((int)now.mutex)-1);
#ifdef VAR_RANGES
		logval("mutex", ((int)now.mutex));
#endif
		;
		_m = 3; goto P999; /* 0 */
	case 16: // STATE 11 - ejemolo.pml:15 - [state = exiting] (0:0:1 - 1)
		IfNotBlocked
		reached[0][11] = 1;
		(trpt+1)->bup.oval = ((P0 *)_this)->state;
		((P0 *)_this)->state = 1;
#ifdef VAR_RANGES
		logval("P:state", ((P0 *)_this)->state);
#endif
		;
		_m = 3; goto P999; /* 0 */
	case 17: // STATE 12 - ejemolo.pml:16 - [((state==exiting))] (14:0:2 - 1)
		IfNotBlocked
		reached[0][12] = 1;
		if (!((((P0 *)_this)->state==1)))
			continue;
		if (TstOnly) return 1; /* TT */
		/* dead 1: state */  (trpt+1)->bup.ovals = grab_ints(2);
		(trpt+1)->bup.ovals[0] = ((P0 *)_this)->state;
#ifdef HAS_CODE
		if (!readtrail)
#endif
			((P0 *)_this)->state = 0;
		/* merge: state = idle(0, 13, 14) */
		reached[0][13] = 1;
		(trpt+1)->bup.ovals[1] = ((P0 *)_this)->state;
		((P0 *)_this)->state = 4;
#ifdef VAR_RANGES
		logval("P:state", ((P0 *)_this)->state);
#endif
		;
		/* merge: .(goto)(0, 15, 14) */
		reached[0][15] = 1;
		;
		_m = 3; goto P999; /* 2 */
	case 18: // STATE 17 - ejemolo.pml:18 - [-end-] (0:0:0 - 1)
		IfNotBlocked
		reached[0][17] = 1;
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

