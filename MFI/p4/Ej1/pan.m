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
	case 3: // STATE 1 - _spin_nvr.tmp:23 - [((!(!((state[1]==6)))&&!((state[1]==5))))] (0:0:0 - 1)
		
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
		if (!(( !( !((now.state[1]==6)))&& !((now.state[1]==5)))))
			continue;
		_m = 3; goto P999; /* 0 */
	case 4: // STATE 8 - _spin_nvr.tmp:28 - [(!((state[1]==5)))] (0:0:0 - 1)
		
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
		if (!( !((now.state[1]==5))))
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
	case 6: // STATE 1 - _spin_nvr.tmp:12 - [((!(!((state[0]==6)))&&!((state[0]==5))))] (0:0:0 - 1)
		
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
		if (!(( !( !((now.state[0]==6)))&& !((now.state[0]==5)))))
			continue;
		_m = 3; goto P999; /* 0 */
	case 7: // STATE 8 - _spin_nvr.tmp:17 - [(!((state[0]==5)))] (0:0:0 - 1)
		
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
		if (!( !((now.state[0]==5))))
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
	case 11: // STATE 1 - ejecicio1Mod.pml:57 - [(run Q(0))] (0:0:0 - 1)
		IfNotBlocked
		reached[1][1] = 1;
		if (!(addproc(II, 1, 0, 0)))
			continue;
		_m = 3; goto P999; /* 0 */
	case 12: // STATE 2 - ejecicio1Mod.pml:57 - [(run Q(1))] (0:0:0 - 1)
		IfNotBlocked
		reached[1][2] = 1;
		if (!(addproc(II, 1, 0, 1)))
			continue;
		_m = 3; goto P999; /* 0 */
	case 13: // STATE 4 - ejecicio1Mod.pml:58 - [-end-] (0:0:0 - 1)
		IfNotBlocked
		reached[1][4] = 1;
		if (!delproc(1, II)) continue;
		_m = 3; goto P999; /* 0 */

		 /* PROC Q */
	case 14: // STATE 1 - ejecicio1Mod.pml:6 - [state[i] = 7] (0:0:1 - 1)
		IfNotBlocked
		reached[0][1] = 1;
		(trpt+1)->bup.oval = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 7;
#ifdef VAR_RANGES
		logval("state[Q:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		_m = 3; goto P999; /* 0 */
	case 15: // STATE 2 - ejecicio1Mod.pml:9 - [(((state[i]==7)&&(turn==i)))] (46:0:2 - 1)
		IfNotBlocked
		reached[0][2] = 1;
		if (!(((now.state[ Index(((int)((P0 *)_this)->i), 2) ]==7)&&(((int)now.turn)==((int)((P0 *)_this)->i)))))
			continue;
		/* merge: turn = ((turn+1)%2)(46, 3, 46) */
		reached[0][3] = 1;
		(trpt+1)->bup.ovals = grab_ints(2);
		(trpt+1)->bup.ovals[0] = ((int)now.turn);
		now.turn = ((((int)now.turn)+1)%2);
#ifdef VAR_RANGES
		logval("turn", ((int)now.turn));
#endif
		;
		/* merge: state[i] = 7(46, 4, 46) */
		reached[0][4] = 1;
		(trpt+1)->bup.ovals[1] = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 7;
#ifdef VAR_RANGES
		logval("state[Q:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		/* merge: .(goto)(0, 47, 46) */
		reached[0][47] = 1;
		;
		_m = 3; goto P999; /* 3 */
	case 16: // STATE 6 - ejecicio1Mod.pml:13 - [((state[i]==7))] (0:0:0 - 1)
		IfNotBlocked
		reached[0][6] = 1;
		if (!((now.state[ Index(((int)((P0 *)_this)->i), 2) ]==7)))
			continue;
		_m = 3; goto P999; /* 0 */
	case 17: // STATE 7 - ejecicio1Mod.pml:13 - [state[i] = 6] (0:0:1 - 1)
		IfNotBlocked
		reached[0][7] = 1;
		(trpt+1)->bup.oval = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 6;
#ifdef VAR_RANGES
		logval("state[Q:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		_m = 3; goto P999; /* 0 */
	case 18: // STATE 8 - ejecicio1Mod.pml:15 - [((((state[i]==6)&&(mutex==0))&&(turn==i)))] (46:0:3 - 1)
		IfNotBlocked
		reached[0][8] = 1;
		if (!((((now.state[ Index(((int)((P0 *)_this)->i), 2) ]==6)&&(((int)now.mutex)==0))&&(((int)now.turn)==((int)((P0 *)_this)->i)))))
			continue;
		/* merge: turn = ((turn+1)%2)(46, 9, 46) */
		reached[0][9] = 1;
		(trpt+1)->bup.ovals = grab_ints(3);
		(trpt+1)->bup.ovals[0] = ((int)now.turn);
		now.turn = ((((int)now.turn)+1)%2);
#ifdef VAR_RANGES
		logval("turn", ((int)now.turn));
#endif
		;
		/* merge: mutex = (mutex+1)(46, 10, 46) */
		reached[0][10] = 1;
		(trpt+1)->bup.ovals[1] = ((int)now.mutex);
		now.mutex = (((int)now.mutex)+1);
#ifdef VAR_RANGES
		logval("mutex", ((int)now.mutex));
#endif
		;
		/* merge: state[i] = 5(46, 11, 46) */
		reached[0][11] = 1;
		(trpt+1)->bup.ovals[2] = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 5;
#ifdef VAR_RANGES
		logval("state[Q:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		/* merge: .(goto)(0, 47, 46) */
		reached[0][47] = 1;
		;
		_m = 3; goto P999; /* 4 */
	case 19: // STATE 13 - ejecicio1Mod.pml:20 - [((state[i]==5))] (0:0:0 - 1)
		IfNotBlocked
		reached[0][13] = 1;
		if (!((now.state[ Index(((int)((P0 *)_this)->i), 2) ]==5)))
			continue;
		_m = 3; goto P999; /* 0 */
	case 20: // STATE 14 - ejecicio1Mod.pml:22 - [mutex = (mutex-1)] (0:0:1 - 1)
		IfNotBlocked
		reached[0][14] = 1;
		(trpt+1)->bup.oval = ((int)now.mutex);
		now.mutex = (((int)now.mutex)-1);
#ifdef VAR_RANGES
		logval("mutex", ((int)now.mutex));
#endif
		;
		_m = 3; goto P999; /* 0 */
	case 21: // STATE 15 - ejecicio1Mod.pml:24 - [state[i] = 4] (0:46:1 - 1)
		IfNotBlocked
		reached[0][15] = 1;
		(trpt+1)->bup.oval = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 4;
#ifdef VAR_RANGES
		logval("state[Q:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		/* merge: .(goto)(46, 20, 46) */
		reached[0][20] = 1;
		;
		/* merge: .(goto)(0, 47, 46) */
		reached[0][47] = 1;
		;
		_m = 3; goto P999; /* 2 */
	case 22: // STATE 20 - ejecicio1Mod.pml:29 - [.(goto)] (0:46:0 - 4)
		IfNotBlocked
		reached[0][20] = 1;
		;
		/* merge: .(goto)(0, 47, 46) */
		reached[0][47] = 1;
		;
		_m = 3; goto P999; /* 1 */
	case 23: // STATE 16 - ejecicio1Mod.pml:25 - [state[i] = 3] (0:46:1 - 1)
		IfNotBlocked
		reached[0][16] = 1;
		(trpt+1)->bup.oval = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 3;
#ifdef VAR_RANGES
		logval("state[Q:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		/* merge: .(goto)(46, 20, 46) */
		reached[0][20] = 1;
		;
		/* merge: .(goto)(0, 47, 46) */
		reached[0][47] = 1;
		;
		_m = 3; goto P999; /* 2 */
	case 24: // STATE 17 - ejecicio1Mod.pml:26 - [state[i] = 2] (0:46:1 - 1)
		IfNotBlocked
		reached[0][17] = 1;
		(trpt+1)->bup.oval = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 2;
#ifdef VAR_RANGES
		logval("state[Q:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		/* merge: .(goto)(46, 20, 46) */
		reached[0][20] = 1;
		;
		/* merge: .(goto)(0, 47, 46) */
		reached[0][47] = 1;
		;
		_m = 3; goto P999; /* 2 */
	case 25: // STATE 18 - ejecicio1Mod.pml:27 - [state[i] = 1] (0:46:1 - 1)
		IfNotBlocked
		reached[0][18] = 1;
		(trpt+1)->bup.oval = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 1;
#ifdef VAR_RANGES
		logval("state[Q:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		/* merge: .(goto)(46, 20, 46) */
		reached[0][20] = 1;
		;
		/* merge: .(goto)(0, 47, 46) */
		reached[0][47] = 1;
		;
		_m = 3; goto P999; /* 2 */
	case 26: // STATE 22 - ejecicio1Mod.pml:30 - [((state[i]==4))] (0:0:0 - 1)
		IfNotBlocked
		reached[0][22] = 1;
		if (!((now.state[ Index(((int)((P0 *)_this)->i), 2) ]==4)))
			continue;
		_m = 3; goto P999; /* 0 */
	case 27: // STATE 23 - ejecicio1Mod.pml:30 - [state[i] = 7] (0:0:1 - 1)
		IfNotBlocked
		reached[0][23] = 1;
		(trpt+1)->bup.oval = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 7;
#ifdef VAR_RANGES
		logval("state[Q:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		_m = 3; goto P999; /* 0 */
	case 28: // STATE 24 - ejecicio1Mod.pml:32 - [(((state[i]==4)&&(turn==i)))] (46:0:2 - 1)
		IfNotBlocked
		reached[0][24] = 1;
		if (!(((now.state[ Index(((int)((P0 *)_this)->i), 2) ]==4)&&(((int)now.turn)==((int)((P0 *)_this)->i)))))
			continue;
		/* merge: turn = ((turn+1)%2)(46, 25, 46) */
		reached[0][25] = 1;
		(trpt+1)->bup.ovals = grab_ints(2);
		(trpt+1)->bup.ovals[0] = ((int)now.turn);
		now.turn = ((((int)now.turn)+1)%2);
#ifdef VAR_RANGES
		logval("turn", ((int)now.turn));
#endif
		;
		/* merge: state[i] = 4(46, 26, 46) */
		reached[0][26] = 1;
		(trpt+1)->bup.ovals[1] = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 4;
#ifdef VAR_RANGES
		logval("state[Q:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		/* merge: .(goto)(0, 47, 46) */
		reached[0][47] = 1;
		;
		_m = 3; goto P999; /* 3 */
	case 29: // STATE 28 - ejecicio1Mod.pml:36 - [((state[i]==3))] (0:0:0 - 1)
		IfNotBlocked
		reached[0][28] = 1;
		if (!((now.state[ Index(((int)((P0 *)_this)->i), 2) ]==3)))
			continue;
		_m = 3; goto P999; /* 0 */
	case 30: // STATE 29 - ejecicio1Mod.pml:36 - [state[i] = 7] (0:0:1 - 1)
		IfNotBlocked
		reached[0][29] = 1;
		(trpt+1)->bup.oval = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 7;
#ifdef VAR_RANGES
		logval("state[Q:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		_m = 3; goto P999; /* 0 */
	case 31: // STATE 30 - ejecicio1Mod.pml:38 - [(((state[i]==3)&&(turn==i)))] (46:0:2 - 1)
		IfNotBlocked
		reached[0][30] = 1;
		if (!(((now.state[ Index(((int)((P0 *)_this)->i), 2) ]==3)&&(((int)now.turn)==((int)((P0 *)_this)->i)))))
			continue;
		/* merge: turn = ((turn+1)%2)(46, 31, 46) */
		reached[0][31] = 1;
		(trpt+1)->bup.ovals = grab_ints(2);
		(trpt+1)->bup.ovals[0] = ((int)now.turn);
		now.turn = ((((int)now.turn)+1)%2);
#ifdef VAR_RANGES
		logval("turn", ((int)now.turn));
#endif
		;
		/* merge: state[i] = 3(46, 32, 46) */
		reached[0][32] = 1;
		(trpt+1)->bup.ovals[1] = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 3;
#ifdef VAR_RANGES
		logval("state[Q:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		/* merge: .(goto)(0, 47, 46) */
		reached[0][47] = 1;
		;
		_m = 3; goto P999; /* 3 */
	case 32: // STATE 34 - ejecicio1Mod.pml:42 - [((state[i]==2))] (0:0:0 - 1)
		IfNotBlocked
		reached[0][34] = 1;
		if (!((now.state[ Index(((int)((P0 *)_this)->i), 2) ]==2)))
			continue;
		_m = 3; goto P999; /* 0 */
	case 33: // STATE 35 - ejecicio1Mod.pml:42 - [state[i] = 7] (0:0:1 - 1)
		IfNotBlocked
		reached[0][35] = 1;
		(trpt+1)->bup.oval = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 7;
#ifdef VAR_RANGES
		logval("state[Q:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		_m = 3; goto P999; /* 0 */
	case 34: // STATE 36 - ejecicio1Mod.pml:44 - [(((state[i]==3)&&(turn==i)))] (46:0:2 - 1)
		IfNotBlocked
		reached[0][36] = 1;
		if (!(((now.state[ Index(((int)((P0 *)_this)->i), 2) ]==3)&&(((int)now.turn)==((int)((P0 *)_this)->i)))))
			continue;
		/* merge: turn = ((turn+1)%2)(46, 37, 46) */
		reached[0][37] = 1;
		(trpt+1)->bup.ovals = grab_ints(2);
		(trpt+1)->bup.ovals[0] = ((int)now.turn);
		now.turn = ((((int)now.turn)+1)%2);
#ifdef VAR_RANGES
		logval("turn", ((int)now.turn));
#endif
		;
		/* merge: state[i] = 2(46, 38, 46) */
		reached[0][38] = 1;
		(trpt+1)->bup.ovals[1] = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 2;
#ifdef VAR_RANGES
		logval("state[Q:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		/* merge: .(goto)(0, 47, 46) */
		reached[0][47] = 1;
		;
		_m = 3; goto P999; /* 3 */
	case 35: // STATE 40 - ejecicio1Mod.pml:48 - [((state[i]==1))] (0:0:0 - 1)
		IfNotBlocked
		reached[0][40] = 1;
		if (!((now.state[ Index(((int)((P0 *)_this)->i), 2) ]==1)))
			continue;
		_m = 3; goto P999; /* 0 */
	case 36: // STATE 41 - ejecicio1Mod.pml:48 - [state[i] = 7] (0:0:1 - 1)
		IfNotBlocked
		reached[0][41] = 1;
		(trpt+1)->bup.oval = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 7;
#ifdef VAR_RANGES
		logval("state[Q:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		_m = 3; goto P999; /* 0 */
	case 37: // STATE 42 - ejecicio1Mod.pml:50 - [(((state[i]==4)&&(turn==i)))] (46:0:2 - 1)
		IfNotBlocked
		reached[0][42] = 1;
		if (!(((now.state[ Index(((int)((P0 *)_this)->i), 2) ]==4)&&(((int)now.turn)==((int)((P0 *)_this)->i)))))
			continue;
		/* merge: turn = ((turn+1)%2)(46, 43, 46) */
		reached[0][43] = 1;
		(trpt+1)->bup.ovals = grab_ints(2);
		(trpt+1)->bup.ovals[0] = ((int)now.turn);
		now.turn = ((((int)now.turn)+1)%2);
#ifdef VAR_RANGES
		logval("turn", ((int)now.turn));
#endif
		;
		/* merge: state[i] = 1(46, 44, 46) */
		reached[0][44] = 1;
		(trpt+1)->bup.ovals[1] = now.state[ Index(((int)((P0 *)_this)->i), 2) ];
		now.state[ Index(((P0 *)_this)->i, 2) ] = 1;
#ifdef VAR_RANGES
		logval("state[Q:i]", now.state[ Index(((int)((P0 *)_this)->i), 2) ]);
#endif
		;
		/* merge: .(goto)(0, 47, 46) */
		reached[0][47] = 1;
		;
		_m = 3; goto P999; /* 3 */
	case 38: // STATE 49 - ejecicio1Mod.pml:55 - [-end-] (0:0:0 - 1)
		IfNotBlocked
		reached[0][49] = 1;
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

