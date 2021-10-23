/****************************************
** Ejercicios boletín - Cuestión 2.9.a **
*****************************************/
#pragma omp parallel sections
{
    #pragma omp section
    minx = minimo(x,n);       /* T1 */

    #pragma omp section
    maxx = maximo(x,n);       /* T2 */

    #pragma omp section
    calcula_y(y,x,n);         /* T4 */ 
}
#pragma omp parllel sections
{
    #pragma omp section
    calcula_z(z,minx,maxx,n); /* T3 */ // Dependecia de flujo con T1 y T2
    #pragma omp section
    calcula_x(x,y,n);         /* T5 */ // Dependecia de flujo con T4 con la variable y, y una antidepencia con la variable x
}
calcula_v(v,z,x);         /* T6 */ // Dependecia de flujo con T3 y con T5