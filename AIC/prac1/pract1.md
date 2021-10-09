# Pract1 AIC
## STD
❯ time scalar-std 100000 1024
Rep = 100000 / size = 1024
scalar-std 100000 1024  
0,60s user 
0,00s system 
99% cpu 
0,606 total

## SSE 
❯ time scalar-sse 100000 1024
Rep = 100000 / size = 1024
scalar-sse 100000 1024  
0,52s user 
0,00s system 
99% cpu 
0,517 total

## Load
❯ time scalar-load 100000 1024
Rep = 100000 / size = 1024
scalar-load 100000 1024  
0,41s user 
0,00s system 
99% cpu 
0,416 total

## Calculos 
```
Tstd = 0,606
= 0,606

Tsse = 0,517
= 0,517

Tload = 0,416
= 0,416

S = (Tstd - Tload)/(Tsse - Tload)
= 1,88118811881188118812
```

## STD 
❯ time matrix-std 1 1024
Rep = 1 / size = 1024
matrix-std 1 1024  
2,58s user 
0,00s system 
99% cpu 
2,583 total

## SSE
❯ time matrix-sse 1 1024
Rep = 1 / size = 1024
matrix-sse 1 1024  
1,61s user 
0,00s system 
99% cpu 
1,615 total

## RES
❯ time matrix-res 1 1024
Rep = 1 / size = 1024
matrix-res 1 1024  
0,45s user 
0,01s system 
99% cpu 
0,463 total

## Caluclos 
```
Tmat_std = 2,583
= 2,583

Tmat_sse = 1,615
= 1,615

Tmat_res = 0,463
= 0,463

S' = Tmat_std /  Tmat_sse
= 1,59938080495356037152

F = (Tmat_std - Tmat_res)/Tmat_std
= 0,82075106465350367789
``` 

## Dhrystone

dhrystone  
0,34s user
0,00s system 
7% cpu

## Whetstone

whetstone 10000  
0,12s user 
0,00s system 
99% cpu 
0,119 total

## Gcc
14

## Vx
0,87


## Tablas
