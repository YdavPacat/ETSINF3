#include <omp.h>
#include <stdio.h>
#include <stdlib.h>

int main (int argc, char *argv[]) {

int nthreads, tid;

/* Arranca un conjunto de threads se guarda el identificador de proceso y la cantidad de procesos que hay */
#pragma omp parallel private(nthreads, tid)
  {

   /* Obtengo quien soy */
   tid = omp_get_thread_num();
   printf("Hola mundo desde el thread = %d\n", tid);

   /* Solo lo hace el master */
   if (tid == 0) 
     {
     nthreads = omp_get_num_threads();
     printf("Numero de threads total = %d\n", nthreads);
     }

  } /* Final de la región paralela */

}
