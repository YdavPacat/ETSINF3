/**************************************
** Ejercicios boletín - Cuestión 2.6 **
***************************************/

int n=...;
double a,b[3];

#pragma omp parallel sections private(a)
{

    #pragma omp section
    {
        a = -1.8;
        fun1(n,&a);
        b[0] = a;
    } 

    #pragma omp section
    {
        a = 3.2;
        fun2(n,&a);
        b[1] = a;
    }

    #pragma omp section
    {
        a = 0.25;
        fun3(n,&a);
        b[2] = a;
    }
}

