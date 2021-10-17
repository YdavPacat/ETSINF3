/*****************************************
** Ejercicios boletín - Cuestión 3.10.a **
******************************************/
double transferencias(double saldos[], int origenes[],
int destinos[], double cantidades[], int n)
{
    int i, i1, i2;
    double dinero, maxtransf=0;
    #pragma omp parallel for private(i1,i2,dinero) \
                             reduction (max:maxtransf)
    for (i=0; i<n; i++) {
        /* Procesar transferencia i: La cantidad transferida es
        * cantidades[i], que se mueve de la cuenta origenes[i]
        * a la cuenta destinos[i]. Se actualizan los saldos de
        * ambas cuentas y la cantidad maxima */
        i1 = origenes[i];
        i2 = destinos[i];
        dinero = cantidades[i];
        #pragma omp atomic
        saldos[i1] -= dinero;
        #pragma omp atomic
        saldos[i2] += dinero;
        if (dinero>maxtransf)  
            maxtransf = dinero;
    }
    return maxtransf;
}
/*****************************************
** Ejercicios boletín - Cuestión 3.10.b **
******************************************/
double transferencias(double saldos[], int origenes[],
int destinos[], double cantidades[], int n)
{
    int i, i1, i2, indtransf;
    double dinero, maxtransf=0;
    #pragma omp parallel for private(i1,i2,dinero) \
                             reduction (max:maxtransf)
    for (i=0; i<n; i++) {
        /* Procesar transferencia i: La cantidad transferida es
        * cantidades[i], que se mueve de la cuenta origenes[i]
        * a la cuenta destinos[i]. Se actualizan los saldos de
        * ambas cuentas y la cantidad maxima */
        i1 = origenes[i];
        i2 = destinos[i];
        dinero = cantidades[i];
        #pragma omp atomic
        saldos[i1] -= dinero;
        #pragma omp atomic
        saldos[i2] += dinero;
        if (dinero>maxtransf) {
            #pragma omp critical
            if (dinero>maxtransf){  
                maxtransf = dinero;
                indtransf = i;
            }
        }
    }
    printf("Maxima cantidad transferida %.2f euros, correspondiente a la transferencia %d", maxtransf, i);
    return maxtransf;
}