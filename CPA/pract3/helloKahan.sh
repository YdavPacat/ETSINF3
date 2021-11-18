#!/bin/sh
#SBATCH --nodes=2
#SBATCH --ntasks=6
#SBATCH --time=10:00
#SBATCH --partition=cpa 
#SBATCH --output=out_hello.txt 

mpiexec ./hello
