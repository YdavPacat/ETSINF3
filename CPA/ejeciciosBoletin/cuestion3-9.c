
/**************************************
** Ejercicios boletín - Cuestión 3.9.a **
***************************************/
int fucion(int n, double v[]){
    int i, pos_max=-1;
    double suma,norma,aux,max=-1;
    suma = 0;
    #pragma omp parallel
    {
        #pragma omp for reduction(+:suma) 
        for (i=0; i<n; i++) 
            suma = suma + v[i]*v[i];
        norma = sqrt(suma);

        #pragma omp for 
        for(i=0; i<n; i++) 
            v[i] = v[i] / norma;

        #pragma omp for private(aux)
        for (i=0; i<n; i++) {
            aux = v[i];
            if (aux < 0) aux = -aux;
            
            if (aux > max) {
                #pragma omp critical
                if (aux > max) {
                    pos_max = i; max = aux;
                }
            }
        }
    }
    return pos_max;
}

/**************************************
** Ejercicios boletín - Cuestión 3.9.b **
***************************************/
int fucion(int n, double v[]){
    int i, pos_max=-1;
    double suma,norma,aux,max=-1;
    suma = 0;
    #pragma omp parallel
    {
        #pragma omp for reduction(+:suma) schedule(dynamic, 2)
        for (i=0; i<n; i++) 
            suma = suma + v[i]*v[i];
        norma = sqrt(suma);

        #pragma omp for schedule(dynamic, 2)
        for(i=0; i<n; i++) 
            v[i] = v[i] / norma;

        #pragma omp for private(aux) schedule(dynamic, 2)
        for (i=0; i<n; i++) {
            aux = v[i];
            if (aux < 0) aux = -aux;
            
            if (aux > max) {
                #pragma omp critical
                if (aux > max) {
                    pos_max = i; max = aux;
                }
            }
        }
    }
    return pos_max;
}

