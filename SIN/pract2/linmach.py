import math
import numpy as np

def linmach(w,x):
  """ Clasifica la muestra 'x' utilizando las funciones discriminantes de 'w'

  Argumentos:
  - w: Matriz de pesos (D + 1, C). La columna 'c' contiene el vector
    de pesos (notación homogénea) de la función discriminante asociada
    a la clase 'c'.
  - x: Muestra a clasificar, en notación homogénea (D+1).

  Devuelve:
  - cstar: Indice de la clase asignada por el clasificador a la muestra 'x'
  """
  C = w.shape[1]; cstar=1; max=float('-inf');
  for c in range(C):
    g=np.dot(w[:,c],x);
    if g>max:
      max=g; cstar=c;
  return cstar;
