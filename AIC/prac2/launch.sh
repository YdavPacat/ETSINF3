#!/bin/bash
./mips-m -d p -c s3 -f apxpy.s -j
cp ./index.htm ./apxpy/apxpy.html

sleep 1

./mips-m -d p -c pnt3 -f apxpy.s -j 
cp ./index.htm ./apxpy/apxpy-pnt.html

sleep 1

./mips-m -d c -c pnt3 -f apxpy.s  -j
cp ./index.htm ./apxpy/apxpy-pnt-corto.html

sleep 1

./mips-m -d c -c pnt3 -f apxpy-p3.s -j
cp ./index.htm ./apxpy-p3/apxpy-p3.html

sleep 1

./mips-m -d c -c pnt1 -f apxpy-p1.s  -j
cp ./index.htm ./apxpy-p1/apxpy-p1.html

sleep 1

./mips-m -d c -c ds1 -f apxpy-d1.s  -j
cp ./index.htm ./apxpy-d1/apxpy-d1.html