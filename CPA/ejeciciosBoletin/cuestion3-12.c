/*****************************************
** Ejercicios boletín - Cuestión 3.12.a **
******************************************/
int funcion(double A[N][N],double posiciones[][2])
{
    int i,j,k=0;
    double maximo;
    /* Calculamos el máximo */
    maximo = A[0][0];
    #pragma omp parallel
    {
        #pragma omp for private(j) reduction(max:maximo)
        for (i=0;i<N;i++) {
            for (j=0;j<N;j++) {
                if (A[i][j]>maximo) maximo = A[i][j];
            }
        }
        /* Una vez localizado el máximo, buscar sus posiciones */
        #pragma omp for private(j)
        for (i=0;i<N;i++) {
            for (j=0;j<N;j++) {
                if (A[i][j] == maximo) {
                    #pragma omp critical
                    {
                        posiciones[k][0] = i;
                        posiciones[k][1] = j;
                        k = k+1;
                    }
                }
            }
        }
    }
    return k;
}
/*****************************************
** Ejercicios boletín - Cuestión 3.12.b **
******************************************/
int funcion(double A[N][N],double posiciones[][2])
{
    int i,j,k=0,num_maximos,id;
    double maximo;
    /* Calculamos el máximo */
    maximo = A[0][0];
    #pragma omp parallel private(num_maximos,id)
    {
        num_maximos=0;
        id=omp_get_thread_num();
        #pragma omp for private(j) reduction(max:maximo)
        for (i=0;i<N;i++) {
            for (j=0;j<N;j++) {
                if (A[i][j]>maximo) maximo = A[i][j];
            }
        }
        /* Una vez localizado el máximo, buscar sus posiciones */
        #pragma omp for private(j)
        for (i=0;i<N;i++) {
            for (j=0;j<N;j++) {
                if (A[i][j] == maximo) {
                    num_maximos++;
                    #pragma omp critical
                    {
                        posiciones[k][0] = i;
                        posiciones[k][1] = j;
                        k = k+1;
                    }
                }
            }
        }
        printf("Soy el hilo %d y he encontrado %d valores máximos", id, num_maximos);
    }
    return k;
}