#!/bin/sh
#SBATCH --nodes=2
#SBATCH --ntasks=6
#SBATCH --time=10:00
#SBATCH --partition=cpa 
#SBATCH --output=out_mpi_pi.txt 

echo "mpi_pi"
mpiexec ./mpi_pi
echo ""
echo "mpi_pim"
mpiexec ./mpi_pim
echo ""
