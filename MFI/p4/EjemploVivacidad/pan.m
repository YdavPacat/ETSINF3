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

		 /* CLAIM liveness1 */
	case 3: // STATE 1 - _spin_nvr.tmp:23 - [((!(!((state[1]==entering)))&&!((state[1]==critical))))] (0:0:0 - 1)
		
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
		reached[4][1] = 1;
		if (!(( !( !((now.state[1]==3)))&& !((now.state[1]==2)))))
			continue;
		_m = 3; goto P999; /* 0 */
	case 4: // STATE 8 - _spin_nvr.tmp:28 - [(!((state[1]==critical)))] (0:0:0 - 1)
		
#if defined(VERI) && !defined(NP)
#if NCLAIMS>1
		{	static int reported8 = 0;
			if (verbose && !reported8)
			{	int nn = (int) ((Pclaim *)pptr(0))->_n;
				printf("depth %ld: Claim %s (%d), state %d (line %d)\n",
					depth, procname[spin_c_typ[nn]], nn, (int) ((Pclaim *)pptr(0))->_p, src_claim[ (int) ((Pclaim *)pptr(0))->_p ]);
				reported8 = 1;
				fflush(stdout);
		}	}
#else
		{	static int reported8 = 0;
			if (verbose && !reported8)
			{	printf("depth %d: Claim, state %d (line %d)\n",
					(int) depth, (int) ((Pclaim *)pptr(0))->_p, src_claim[ (int) ((Pclaim *)pptr(0))->_p ]);
				reported8 = 1;
				fflush(stdout);
		}	}
#endif
#endif
		reached[4][8] = 1;
		if (!( !((now.state[1]==2))))
			continue;
		_m = 3; goto P999; /* 0 */
	case 5: // STATE 13 - _spin_nvr.tmp:30 - [-end-] (0:0:0 - 1)
		
#if defined(VERI) && !defined(NP)
#if NCLAIMS>1
		{	static int reported13 = 0;
			if (verbose && !reported13)
			{	int nn = (int) ((Pclaim *)pptr(0))->_n;
				printf("depth %ld: Claim %s (%d), state %d (line %d)\n",
					depth, procname[spin_c_typ[nn]], nn, (int) ((Pclaim *)pptr(0))->_p, src_claim[ (int) ((Pclaim *)pptr(0))->_p ]);
				reported13 = 1;
				fflush(stdout);
		}	}
#else
		{	static int reported13 = 0;
			if (verbose && !reported13)
			{	printf("depth %d: Claim, state %d (line %d)\n",
					(int) depth, (int) ((Pclaim *)pptr(0))->_p, src_claim[ (int) ((Pclaim *)pptr(0))->_p ]);
				reported13 = 1;
				fflush(stdout);
		}	}
#endif
#endif
		reached[4][13] = 1;
		if (!delproc(1, II)) continue;
		_m = 3; goto P999; /* 0 */

		 /* CLAIM liveness0 */
	case 6: // STATE 1 - _spin_nvr.tmp:12 - [((!(!((state[0]==entering)))&&!((state[0]==critical))))] (0:0:0 - 1)
		
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
		reached[3][1] = 1;
		if (!(( !( !((now.state[0]==3)))&& !((now.state[0]==2)))))
			continue;
		_m = 3; goto P999; /* 0 */
	case 7: // STATE 8 - _spin_nvr.tmp:17 - [(!((state[0]==critical)))] (0:0:0 - 1)
		
#if defined(VERI) && !defined(NP)
#if NCLAIMS>1
		{	static int reported8 = 0;
			if (verbose && !reported8)
			{	int nn = (int) ((Pclaim *)pptr(0))->_n;
				printf("depth %ld: Claim %s (%d), state %d (line %d)\n",
					depth, procname[spin_c_typ[nn]], nn, (int) ((Pclaim *)pptr(0))->_p, src_claim[ (int) ((Pclaim *)pptr(0))->_p ]);
				reported8 = 1;
				fflush(stdout);
		}	}
#else
		{	static int reported8 = 0;
			if (verbose && !reported8)
			{	printf("depth %d: Claim, state %d (line %d)\n",
					(int) depth, (int) ((Pclaim *)pptr(0))->_p, src_claim[ (int) ((Pclaim *)pptr(0))->_p ]);
				reported8 = 1;
				fflush(stdout);
		}	}
#endif
#endif
		reached[3][8] = 1;
		if (!( !((now.state[0]==2))))
			continue;
		_m = 3; goto P999; /* 0 */
	case 8: // STATE 13 - _spin_nvr.tmp:19 - [-end-] (0:0:0 - 1)
		
#if defined(VERI) && !defined(NP)
#if NCLAIMS>1
		{	static int reported13 = 0;
			if (verbose && !reported13)
			{	int nn = (int) ((Pclaim *)pptr(0))->_n;
				printf("depth %ld: Claim %s (%d), state %d (line %d)\n",
					depth, procname[spin_c_typ[nn]], nn, (int) ((Pclaim *)pptr(0))->_p, src_claim[ (int) ((Pclaim *)pptr(0))->_p ]);
				reported13 = 1;
				fflush(stdout);
		}	}
#else
		{	static int reported13 = 0;
			if (verbose && !reported13)
			{	printf("depth %d: Claim, state %d (line %d)\n",
					(int) depth, (int) ((Pclaim *)pptr(0))->_p, src_claim[ (int) ((Pclaim *)pptr(0))->_p ]);
				reported13 = 1;
				fflush(stdout);
		}	}
#endif
#endif
		reached[3][13] = 1;
		if (!delproc(1, II)) continue;
		_m = 3; goto P999; /* 0 */

		 /* CLAIM security */
	case 9: // STATE 1 - _spin_nvr.tmp:3 - [(!((mutex<2)))] (6:0:0 - 1)
		
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
	case 10: // STATE 10 - _spin_nvr.tmp:8 - [-end-] (0:0:0 - 1)
		
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
	case 11: // STATE 1 - ejemploVivacidad.pml:24 - [(run P(0))] (0:0:0 - 1)
		IfNotBlocked
		reached[1][1] = 1;
		if (!(addproc(II, 1, 0, 0)))
			continue;
		_m = 3; goto P999; /* 0 */
	case 12: // STATE 2 - ejemploVivacidad.pml:24 - [(run P(1))] (0:0:0 - 1)
		IfNotBlocked
		reached[1][2] = 1;
		if (!(addproc(II, 1, 0, 1)))
			continue;
		_m = 3; goto P999; /* 0 */
	case 13: // STATE 4 - ejemploVivacidad.pml:25 - [-end-] (0:0:0 - 1)
		IfNotBlocked
		reached[1][4] = 1;
		if (!delproc(1, II)) continue;
		_m = 3; goto P999; /* 0 */

		 /* PROC P */
	case 14: // STATE 1 - ejemploVivacidad.pml:6 - [state[i] = idle] (0:0:1 - 1)
		IfNotBlocked
		reached[0][1] = 1;
		(trpt+1)->bup.oval = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 4;
#ifdef VAR_RANGES
		logval("state[P:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		_m = 3; goto P999; /* 0 */
	case 15: // STATE 2 - ejemploVivacidad.pml:8 - [((state[i]==idle))] (0:0:0 - 1)
		IfNotBlocked
		reached[0][2] = 1;
		if (!((now.state[ Index(((int)((P0 *)_this)->i), 2) ]==4)))
			continue;
		_m = 3; goto P999; /* 0 */
	case 16: // STATE 3 - ejemploVivacidad.pml:8 - [state[i] = idle] (0:0:1 - 1)
		IfNotBlocked
		reached[0][3] = 1;
		(trpt+1)->bup.oval = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 4;
#ifdef VAR_RANGES
		logval("state[P:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		_m = 3; goto P999; /* 0 */
	case 17: // STATE 4 - ejemploVivacidad.pml:9 - [((state[i]==idle))] (0:0:0 - 1)
		IfNotBlocked
		reached[0][4] = 1;
		if (!((now.state[ Index(((int)((P0 *)_this)->i), 2) ]==4)))
			continue;
		_m = 3; goto P999; /* 0 */
	case 18: // STATE 5 - ejemploVivacidad.pml:9 - [state[i] = entering] (0:0:1 - 1)
		IfNotBlocked
		reached[0][5] = 1;
		(trpt+1)->bup.oval = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 3;
#ifdef VAR_RANGES
		logval("state[P:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		_m = 3; goto P999; /* 0 */
	case 19: // STATE 6 - ejemploVivacidad.pml:11 - [(((state[i]==entering)&&(mutex==0)))] (16:0:2 - 1)
		IfNotBlocked
		reached[0][6] = 1;
		if (!(((now.state[ Index(((int)((P0 *)_this)->i), 2) ]==3)&&(((int)now.mutex)==0))))
			continue;
		/* merge: mutex = (mutex+1)(16, 7, 16) */
		reached[0][7] = 1;
		(trpt+1)->bup.ovals = grab_ints(2);
		(trpt+1)->bup.ovals[0] = ((int)now.mutex);
		now.mutex = (((int)now.mutex)+1);
#ifdef VAR_RANGES
		logval("mutex", ((int)now.mutex));
#endif
		;
		/* merge: state[i] = critical(16, 8, 16) */
		reached[0][8] = 1;
		(trpt+1)->bup.ovals[1] = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 2;
#ifdef VAR_RANGES
		logval("state[P:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		/* merge: .(goto)(0, 17, 16) */
		reached[0][17] = 1;
		;
		_m = 3; goto P999; /* 3 */
	case 20: // STATE 10 - ejemploVivacidad.pml:15 - [((state[i]==critical))] (0:0:0 - 1)
		IfNotBlocked
		reached[0][10] = 1;
		if (!((now.state[ Index(((int)((P0 *)_this)->i), 2) ]==2)))
			continue;
		_m = 3; goto P999; /* 0 */
	case 21: // STATE 11 - ejemploVivacidad.pml:17 - [mutex = (mutex-1)] (0:16:2 - 1)
		IfNotBlocked
		reached[0][11] = 1;
		(trpt+1)->bup.ovals = grab_ints(2);
		(trpt+1)->bup.ovals[0] = ((int)now.mutex);
		now.mutex = (((int)now.mutex)-1);
#ifdef VAR_RANGES
		logval("mutex", ((int)now.mutex));
#endif
		;
		/* merge: state[i] = exiting(16, 12, 16) */
		reached[0][12] = 1;
		(trpt+1)->bup.ovals[1] = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 1;
#ifdef VAR_RANGES
		logval("state[P:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		/* merge: .(goto)(0, 17, 16) */
		reached[0][17] = 1;
		;
		_m = 3; goto P999; /* 2 */
	case 22: // STATE 14 - ejemploVivacidad.pml:20 - [((state[i]==exiting))] (0:0:0 - 1)
		IfNotBlocked
		reached[0][14] = 1;
		if (!((now.state[ Index(((int)((P0 *)_this)->i), 2) ]==1)))
			continue;
		_m = 3; goto P999; /* 0 */
	case 23: // STATE 15 - ejemploVivacidad.pml:20 - [state[i] = idle] (0:0:1 - 1)
		IfNotBlocked
		reached[0][15] = 1;
		(trpt+1)->bup.oval = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 4;
#ifdef VAR_RANGES
		logval("state[P:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		_m = 3; goto P999; /* 0 */
	case 24: // STATE 19 - ejemploVivacidad.pml:22 - [-end-] (0:0:0 - 1)
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

