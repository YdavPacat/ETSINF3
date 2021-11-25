#!/usr/bin/python
import math;
import numpy as np
from linmach import linmach
from confus import confus
from perceptron import perceptron

#Cargar los datos
data=np.loadtxt('./datos/OCR_14x14');

#Preparar variables
N,L=data.shape; 
D=L-1;
labs=np.unique(data[:,L-1])
C=labs.size;

#Preparar los datos. Primero se barajan los datos con una permutación aleatoria.
#Luego, usaremos el 70% para entrenamiento, y el 30% restante para validación

np.random.seed(23);
perm=np.random.permutation(N);
data=data[perm];
NTr=int(round(.7*N));
train=data[:NTr,:]
M=N-NTr;
test=data[NTr:,:];

#Entreno el Perceptron con los datos de entrenamiento
w,E,k=perceptron(train);

rl=np.zeros((M,1));
#Clasifico las muestras de validación
for m in range(M): #Para cada muestra 'm' de validación
  #Paso a notación homogénea
  tem=np.concatenate(([1],test[m,:D]));
  #Obtengo la etiqueta de la clase más probable según el Perceptron
  rl[m]=labs[linmach(w,tem)];

#Número de errores y matriz de confusión
ner,m=confus(test[:,L-1].reshape(M,1),rl);
print('ner=%d'%ner);
print(m);
per=ner/M; #Porcentaje de error
print('per=%.3f'%per);
#Intervalo de confianza del 95%
r=1.96*math.sqrt(per*(1-per)/M); 
print('r = %.3f' % r);
print('I=[%.3f, %.3f]'%(per-r,per+r));
