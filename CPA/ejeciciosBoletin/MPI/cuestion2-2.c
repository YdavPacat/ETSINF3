int i, j;
double s, norm, A[N][N], Alocal[N][N], slocal;
int myid, nprocs,k
MPI_Comm_rank(MPI_COMM_WORLD,&myid);
MPI_Comm_size(MPI_COMM_WORLD,&nprocs);

k=N/nporcs;

if (myid==0)
   leermat(A);

for(i=0; i<k; i++;){
	MPI_Scatter(A[i*nporcs][0], MPI_COMM_WORLD, Alocal[][],N,MPI_DOUBLE,0,MPI_COMM_WORLD);
}

slocal = 0.0;

for (i=0;i<k;i++) {
    for (j=0;j<N;j++) 
        slocal += Alocal[i][j]*Alocal[i][j];
}

MPI_Reduce(&slocal, &s,1,MPI_DOUBLE,MPI_SUM,0,MPI_COMM_WORLD);

if(myid == 0){
    norm = sqrt(s);
    printf("norm=%f\n",norm);
}