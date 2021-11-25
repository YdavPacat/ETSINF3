import numpy as np

def perceptron(data,b=0.1,a=1.0,K=200):
  """ Entrena un clasificador a partir de las muestras de 'data'

  Argumentos:
  - data: Matriz (N x L). Cada fila contiene los datos asociados a una muestra,
    * Las primeras D columnas contiene el vector de características de la muestra. 
    * La última columna contiene la etiqueta de clase de la muestra.
  - b: margen del Perceptron.  (default: 0.1)
  - a: factor de aprendizaje del Perceptron. (default: 1.0)
  - K: Número de iteraciones máximas del algoritmo Perceptron. (default: 200)

  Devuelve:
  - w: Matriz de pesos (D + 1 x C) aprendida mediante el algoritmo Perceptron.
    La columna 'c' contiene el vector de pesos (notación homogénea)
    de la función discriminante asociada a la clase 'c'.
  - E: Número de errores/muestras mal clasificadas en la última iteración.
  - k: Número de iteraciones realizadas.
  """
  (N,L)=data.shape; 
  D=L-1; 
  labs=np.unique(data[:,L-1]); #Obtener las etiquetas de clase
  C=labs.size;
  w = np.zeros((L,C)); #Inicializar matriz pesos a 0
  for k in range(1,K+1): #K iteraciones del algoritmo Perceptron
    E=0;
    for n in range(N):
     xn=np.concatenate(([1],data[n,:D])); #Paso la muestra a notación homogénea
     #Obtener el indice de la clase de la muestra
     cn=np.where(labs==data[n,L-1])[0][0]; 
     er=False;  
     g=np.dot(w[:,cn],xn); #Función discriminante de la clase correcta
     for c in range(C):
      #Compruebo funciones discriminantes de las otras clases
      if c != cn and np.dot(w[:,c],xn) + b > g:
        #Si hay error, decremento pesos de las otras clases
        w[:,c] = w[:,c] - a*xn; 
        er=True;
     if er==True:
        #Si hay error, incremento pesos de la clase correcta
        w[:,cn] = w[:,cn] + a*xn; 
        E=E+1;
    #Si no hay errores, el algoritmo converge
    if E==0: 
      break;
  return w,E,k;
