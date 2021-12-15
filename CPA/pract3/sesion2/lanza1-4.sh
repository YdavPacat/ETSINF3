#!/bin/sh
#SBATCH --nodes=1
#SBATCH --ntasks=4
#SBATCH --time=10:00
#SBATCH --partition=cpa 
#SBATCH --output=salida1-4.txt 

mpicc -o newton ./newton.c -lm
mpicc -o newtonMod ./newtonMod.c -lm

echo "Original"
mpiexec ./newton -c5
echo "Modificado"
mpiexec ./newtonMod -c5
