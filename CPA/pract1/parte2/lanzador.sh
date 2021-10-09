#!/bin/bash
#SBATCH --nodes=1
#SBATCH --time=5:00
#SBATCH --partition=cpa
echo "###############################"
echo "# Paralelizando segundo bucle #"
echo "###############################"
echo ""
echo ""
OMP_NUM_THREADS=1  ./pimagenesV1
echo ""
OMP_NUM_THREADS=2  ./pimagenesV1
echo ""
OMP_NUM_THREADS=4  ./pimagenesV1
echo ""
OMP_NUM_THREADS=8  ./pimagenesV1
echo ""
OMP_NUM_THREADS=16 ./pimagenesV1

echo "##############################"
echo "# Paralelizando tercer bucle #"
echo "##############################"
echo ""
echo ""
OMP_NUM_THREADS=1  ./pimagenesV2
echo ""                        
OMP_NUM_THREADS=2  ./pimagenesV2
echo ""                        
OMP_NUM_THREADS=4  ./pimagenesV2
echo ""                        
OMP_NUM_THREADS=8  ./pimagenesV2
echo ""                        
OMP_NUM_THREADS=16 ./pimagenesV2

echo "##############################"
echo "# Paralelizando cuarto bucle #"
echo "##############################"
echo ""
echo ""
OMP_NUM_THREADS=1  ./pimagenesV3
echo ""
OMP_NUM_THREADS=2  ./pimagenesV3
echo ""
OMP_NUM_THREADS=4  ./pimagenesV3
echo ""
OMP_NUM_THREADS=8  ./pimagenesV3
echo ""
OMP_NUM_THREADS=16 ./pimagenesV3

echo "##############################"
echo "# Paralelizando quinto bucle #"
echo "##############################"
echo ""
echo ""
OMP_NUM_THREADS=1  ./pimagenesV4
echo ""
OMP_NUM_THREADS=2  ./pimagenesV4
echo ""
OMP_NUM_THREADS=4  ./pimagenesV4
echo ""
OMP_NUM_THREADS=8  ./pimagenesV4
echo ""
OMP_NUM_THREADS=16 ./pimagenesV4

