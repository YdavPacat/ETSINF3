#!/bin/sh
#SBATCH --nodes=1
#SBATCH --ntasks=4
#SBATCH --time=10:00
#SBATCH --partition=cpa 
#SBATCH --output=salida.txt 

mpiexec ./sistbfSinOut 2000
mpiexec ./sistcfSinOut 2000
