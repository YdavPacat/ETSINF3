/***************************************
** Ejercicios propios - Ejercicio 13a **
****************************************/
double producto_escalar(double x[], double y[], int n){
    int i;
    double suma,suma_local;
    suma=0;
    #pragma omp parallel private(suma_local) 
    {
        suma_local=0;
        #pragma omp parallel for
        for(i=0;i<n;i++)
            suma_local += x[i]*y[i];
        #pragma omp atomic
        suma+=suma_local;
    }
    return suma;
}
/***************************************
** Ejercicios propios - Ejercicio 13b **
****************************************/
double producto_escalar(double x[], double y[], int n){
    int i, id, nhilos;
    double suma,suma_local;
    suma=0;
    #pragma omp parallel private(suma_local, id) 
    {
        id=omp_get_thread_num();
        nhilos=omp_get_num_threads();
        suma_local=0;
        // #pragma omp parallel for
        for(i=id;i<n;i+= nhilos)
            suma_local += x[i]*y[i];
        #pragma omp atomic
        suma+=suma_local;
    }
    return suma;
}