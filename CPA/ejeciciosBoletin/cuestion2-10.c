/****************************************
** Ejercicios boletín - Cuestión 2.9.a **
*****************************************/
double fun1(double a[],int n, int v0)
{
    int i;
    a[0] = v0;
    for (i=1;i<n;i++) // no se puede paralelizar
        a[i] = genera(a[i-1],i);
}
double compara(double x[],double y[],int n)
{
    int i;
    double s=0;
    #pragma omp parallel reduction(+:s)
    for (i=0;i<n;i++)
        s += fabs(x[i]-y[i]);
    return s;
}                
/* fragmento del programa principal (main) */
int i, n=10;
double a[10], b[10], c[10], x=5, y=7, z=11, w;

#pragma omp parallel 
{
    #pragma omp sections
    {
        #pragma omp section
        fun1(a,n,x);        /* T1 */
        #pragma omp section
        fun1(b,n,y);        /* T2 */
        #pragma omp section
        fun1(c,n,z);        /* T3 */
    }
    #pragma omp sections
    {
        #pragma omp section
        x = compara(a,b,n); /* T4 */ //Antidependencia en la variable x y b
        #pragma omp section
        y = compara(a,c,n); /* T5 */ // Depencia de flujo T2
        #pragma omp section
        z = compara(c,b,n); /* T6 */ // Depecia de flujo T3 
    }
}
w = x+y+z;          /* T7 */ // Dependencia de flujo T4, T5, T6
printf("w:%f\n", w);
