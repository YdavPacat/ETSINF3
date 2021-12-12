#!/bin/sh
#SBATCH --nodes=1
#SBATCH --ntasks=4
#SBATCH --time=10:00
#SBATCH --partition=cpa 
#SBATCH --output=salidaMxv1Nodo4.txt 

mpicc mxv1.c -o mxv1

mpiexec ./mxv1 

mpiexec ./mxv2 

mpiexec ./mxv1_modificado 
