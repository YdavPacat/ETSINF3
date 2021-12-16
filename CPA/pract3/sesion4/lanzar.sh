#!/bin/sh
#SBATCH --nodes=1
#SBATCH --ntasks=8
#SBATCH --time=10:00
#SBATCH --partition=cpa 
#SBATCH --output=salida.txt 

mpiexec ./sistbfSinOut 1500
mpiexec ./sistcfSinOut 1500