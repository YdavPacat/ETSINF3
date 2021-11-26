#!/bin/sh
#SBATCH --nodes=1
#SBATCH --ntasks=1
#SBATCH --time=10:00
#SBATCH --partition=cpa 
#SBATCH --output=salida.txt 

mpiexec ./newton -c5
# Da error