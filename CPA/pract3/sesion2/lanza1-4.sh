#!/bin/sh
#SBATCH --nodes=1
#SBATCH --ntasks=4
#SBATCH --time=10:00
#SBATCH --partition=cpa 
#SBATCH --output=salida1-4.txt 

mpicc -Wall -o newton ./newton.c
mpicc -Wall -o newton ./newtonMod.c

mpiexec ./newton -c5
mpiexec ./newtonMod -c5