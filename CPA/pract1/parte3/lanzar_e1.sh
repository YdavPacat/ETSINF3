#!/bin/bash
#SBATCH --nodes=1
#SBATCH --time=5:00
#SBATCH --partition=cpa
OMP_NUM_THREADS=1 ./primo_e1
OMP_NUM_THREADS=2 ./primo_e1
OMP_NUM_THREADS=4 ./primo_e1
OMP_NUM_THREADS=8 ./primo_e1
OMP_NUM_THREADS=16 ./primo_e1
OMP_NUM_THREADS=32 ./primo_e1