#!/bin/sh
#SBATCH --nodes=2
#SBATCH --ntasks=2
#SBATCH --time=10:00
#SBATCH --partition=cpa 
#SBATCH --output=salidaMxv1Nodo2.txt 

mpicc mxv1.c -o mxv1

mpiexec ./mxv1 
