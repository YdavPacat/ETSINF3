#include <omp.h> 
int funcion(int x){
        return x;
}
int main (){
    int i, a, niter, n, id;
    int v[10];
    
    #pragma omp parallel private(a, niter, id) 
    {
        niter = 0;
        id = omp_get_thread_num();
        #pragma omp for
        for (i=0; i<n; i++){
            a = funcion(i*4);
            v[i] = a+2;
            niter++; 
        }
        printf("Soy el hilo %d y he ejecutado %d iteraciones del bucle", id, niter);
    }
}