import numpy as np

def confus(truelabs,recolabs):
  """ Calcula el número de errores y la matriz de confusión

  Argumentos:
  - truelabs: Etiquetas de clase reales (N x 1)
  - recolabs: Etiquetas de clase asignadas por el modelo (N x 1)

  Devuelve:
  - nerr: Número de errores
  - m: Matriz de confusión (C x C).
    C[i,j] indica el número de muestras de la clase 'i'
    que se han clasificado en la clase 'j'.
  """
  N=truelabs.size; 
  labs=np.unique(np.concatenate([truelabs,recolabs]));
  C=labs.size; 
  m=np.zeros((C,C));
  for n in range(N): # Para cada muestra 'n'
    tc=np.where(labs==truelabs[n])[0][0]; #Etiqueta de clase -> Indice de clase
    rl=np.where(labs==recolabs[n])[0][0]; #Etiqueta de clase -> Indice de clase
    m[tc,rl]+=1;
  a=0;
  #La diagonal contiene las muestras clasificadas correctamente
  for c in range(C):
    a+=m[c,c];
  #Erores = N - nr.aciertos
  nerr=N-a;
  return nerr,m; 
