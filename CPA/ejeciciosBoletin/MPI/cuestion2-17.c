int main(int argc, char *argv[]) {
    int i, j;
    double a, b, A[M][N], B[M][N], C[M][N];

    double a, b, Alocal[M][N], Blocal[M][N], Clocal[M][N];
    int myid, nprocs, k;
    MPI_Comm_rank(MPI_COMM_WORLD, &myid);
    MPI_Comm_size(MPI_COMM_WORLD, &nporcs);
    k=M/nprocs;

    if(myid==0)
        LeeOperandos(A, B, &a, &b);

    MPI_Bcast(&a,1,MPI_DOUBLE,0,MPI_COMM_WORLD);
    MPI_Bcast(&b,1,MPI_DOUBLE,0,MPI_COMM_WORLD);

    for(i = 0; i < k; i++){
        MPI_Scatter(&A[i*procs][0], N, MPI_DOUBLEM, &Alocal[i][0], N, MPI_DOUBLE, 0, MPI_COMM_WORLD);
        MPI_Scatter(&B[i*procs][0], N, MPI_DOUBLEM, &Blocal[i][0], N, MPI_DOUBLE, 0, MPI_COMM_WORLD);
    }

    for (i=0; i<k; i++) {
        for (j=0; j<N; j++) {
            Clocal[i][j] = a*Alocal[i][j] + b*Blocal[i][j];
        }
    }

    for(i = 0; i < k; i++){
        MPI_Gather(&Clocal[i][0], N, MPI_DOUBLE, &C[i*nprocs][0], N, MPI_DOUBLE, 0, MPI_COMM_WORLD);
    }

    if (myid == 0)
        EscribeMatriz(C);

    return 0;
}
