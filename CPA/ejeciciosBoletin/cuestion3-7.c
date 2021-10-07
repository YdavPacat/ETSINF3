/****************************************
** Ejercicios boletín - Cuestión 3.7.a **
*****************************************/
#pragma omp parallel for private(j, s)
for(i = 0; i < n; i++) {
    s = 0;
    for (j = 0; j < i; j++) {
        s += A[i][j]*b[j];
    }
    c[i] = s;
    #pragma omp atomic
    x[ind[i]] += s;
}
/****************************************
** Ejercicios boletín - Cuestión 3.7.b **
*****************************************/
for(i = 0; i < n; i++) {
    s = 0;
    #pragma omp parallel for reduction(+:s)
    for (j = 0; j < i; j++) {
        s += A[i][j]*b[j];
    }
    c[i] = s;
    x[ind[i]] += s;
}
/****************************************
** Ejercicios boletín - Cuestión 3.7.c **
*****************************************/
#pragma omp parallel for private(j, s)
for(i = 0; i < n; i++) {
    s = 0;
    for (j = 0; j < i; j++) {
        s += A[i][j]*b[j];
    }
    c[i] = s;
    #pragma omp atomic
    x[ind[i]] += s;
}