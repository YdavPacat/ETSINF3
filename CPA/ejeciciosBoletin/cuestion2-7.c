/****************************************
** Ejercicios boletín - Cuestión 2.7.a **
*****************************************/

// El primer argumento de todas las funciones usadas es de 
// salida y el resto de argumentos son argumentos de entrada
void func(double a[],double b[],double c[],double d[]){
    f1(a,b);
    f2(b,b); // f2 no puede ejcutarse antes que f1 (antidependencia)

    f3(c,d); 
    f4(d,d); // f4 no puede ejecutarse antes que f3 (antidependencia)
    
    f5(a,a,b,c,d); // dependencia de flujo con f1, f2, f3, f4
}

/****************************************
** Ejercicios boletín - Cuestión 2.7.b **
*****************************************/

// El primer argumento de todas las funciones usadas es de 
// salida y el resto de argumentos son argumentos de entrada
void func(double a[],double b[],double c[],double d[]){
    #pragma omp parallel sections
    {
        #pragma omp section
        {
            f1(a,b);
            f2(b,b); // f2 no puede ejcutarse antes que f1 (antidependencia)
        }
        #pragma omp section
        {
            f3(c,d); 
            f4(d,d); // f4 no puede ejecutarse antes que f3 (antidependencia)
        }
    }
    f5(a,a,b,c,d); // dependencia de flujo con f1, f2, f3, f4  
}

/****************************************
** Ejercicios boletín - Cuestión 2.7.c **
*****************************************/


// ¿Cuál será el speedup máximo posible?
// t1 = 1 + 1 + 1 + 1 + 1 = 5 flops
// tp = 1 + 1 + 1 = 3 flops
// sp = t1/tp = 5 / 3 = 1.67


// ¿Se podría mejorar este speedup utilizando
// replicación de datos?
void func(double a[],double b[],double c[],double d[],int n){

    memcpy(b1, b, sizeof(double)*n);
    memcpy(d1, d, sizeof(double)*n);

    f1(a,b1);
    f2(b,b1); // f2 no puede ejcutarse antes que f1 (antidependencia)

    f3(c,d1); 
    f4(d,d1); // f4 no puede ejecutarse antes que f3 (antidependencia)
    
    f5(a,a,b,c,d); // dependencia de flujo con f1, f2, f3, f4
}
// Speed-up (sp) máximo posible 
// t1 = 1 + 1 + 1 + 1 + 1 = 5 flops
// tp = 1 + 1 = 2 flops
// sp = t1/tp = 5 / 2 = 2.5 

