#!/bin/bash
#SBATCH --nodes=1
#SBATCH --time=5:00
#SBATCH --partition=cpa
echo "###########################"
echo "# Metodo de integración 1 #"
echo "###########################"
echo ""
echo ""
OMP_NUM_THREADS=1 ./pintegral 1 50000000
echo ""
OMP_NUM_THREADS=2 ./pintegral 1 50000000
echo ""
OMP_NUM_THREADS=4 ./pintegral 1 50000000
echo ""
OMP_NUM_THREADS=8 ./pintegral 1 50000000
echo ""
OMP_NUM_THREADS=16 ./pintegral 1 50000000
echo ""
echo ""
echo "###########################"
echo "# Metodo de integración 2 #"
echo "###########################"
echo ""
echo ""
OMP_NUM_THREADS=1 ./pintegral 2 50000000
echo ""
OMP_NUM_THREADS=2 ./pintegral 2 50000000
echo ""
OMP_NUM_THREADS=4 ./pintegral 2 50000000
echo ""
OMP_NUM_THREADS=8 ./pintegral 2 50000000
echo ""
OMP_NUM_THREADS=16 ./pintegral 2 50000000
echo ""
echo ""
