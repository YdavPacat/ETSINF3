#!/usr/bin/python
import sys; 
import math; 
import numpy as np
from perceptron import perceptron; 
from confus import confus
from linmach import linmach

if len(sys.argv)!=4:
  print('Usage: %s <data> <alphas> <bs>' % sys.argv[0]);
  sys.exit(1);

#Leer argumentos de la línea de comandos
data=np.loadtxt(sys.argv[1]);
alphas=np.fromstring(sys.argv[2],sep=' ');
bs=np.fromstring(sys.argv[3],sep=' ');

# ...
# A COMPLETAR POR EL ALUMNO
# Incluir todos los pasos necesarios para preparar el entrenamiento del Perceptron.
# No hay que olvidarse de preparar los datos y hacer el split
# entrenamiento/validación 70/30%.
# ...
N,L=data.shape; 
D=L-1;
labs=np.unique(data[:,L-1])
C=labs.size;

np.random.seed(23);
perm=np.random.permutation(N);
data=data[perm];
NTr=int(round(.7*N));
train=data[:NTr,:]
M=N-NTr;
test=data[NTr:,:];
print('#      a    b   E   k Ete Ete (%)    Ite (%)');
print('#------- ---- --- --- --- ------- ----------');

for a in alphas:
  for b in bs:
    w,E,k=perceptron(train,b,a); 
    rl=np.zeros((M,1));
    # ...
    # A COMPLETAR POR EL ALUMNO
    # Clasificar muestras de validación y mostrar en formato tabla los resultados completos
    # ...
    for m in range(M):
      tem=np.concatenate(([1],test[m,:D]));
      rl[m]=labs[linmach(w,tem)];
      ner,m=confus(test[:,L-1].reshape(M,1),rl);
      per=ner/M;
      r=1.96*math.sqrt(per*(1-per)/M);
      print('I=[%.3f, %.3f]'%(per-r,per+r),end='');



