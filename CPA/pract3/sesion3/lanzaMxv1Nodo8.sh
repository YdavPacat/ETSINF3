#!/bin/sh
#SBATCH --nodes=1
#SBATCH --ntasks=8
#SBATCH --time=10:00
#SBATCH --partition=cpa 
#SBATCH --output=salidaMxv1Nodo8.txt 

mpicc mxv1.c -o mxv1

mpiexec ./mxv1 
