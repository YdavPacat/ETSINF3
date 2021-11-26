#!/bin/sh
#SBATCH --nodes=1
#SBATCH --ntasks=2
#SBATCH --time=10:00
#SBATCH --partition=cpa 
#SBATCH --output=salida1-2.txt 

mpiexec ./newton -c5
# Da error