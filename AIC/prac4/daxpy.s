        ; z = a*x + y
        ; Tama�o de los vectores: 64 palabras
        ; Vector x
	.data
x:      .double 0,1,2,3,4,5,6,7,8,9
        .double 10,11,12,13,14,15,16,17,18,19
        .double 20,21,22,23,24,25,26,27,28,29
        .double 30,31,32,33,34,35,36,37,38,39
        .double 40,41,42,43,44,45,46,47,48,49
        .double 50,51,52,53,54,55,56,57,58,59

	; Vector y
y:      .double 100,100,100,100,100,100,100,100,100,100
	.double 100,100,100,100,100,100,100,100,100,100
	.double 100,100,100,100,100,100,100,100,100,100
	.double 100,100,100,100,100,100,100,100,100,100
	.double 100,100,100,100,100,100,100,100,100,100
	.double 100,100,100,100,100,100,100,100,100,100

        ; Vector z
	; 60 elementos son 480 bytes
z:      .space 480

        ; Escalar a
a:      .double 1

        ; El código
	.text

;aX + Y
start:
        dadd r1,r0,y     ; r1 contiene la direccion de y
        dadd r2,r0,z     ; r2 contiene la direccion de z
        dadd r5,r0,x     ; r2 contiene la direccion de x
        l.d f0,a(r0)     ; f0 contiene a
        dadd r3,r1,#480	 ; 60 elementos son 480 bytes
loop:
        l.d f2,0(r1)     ; cargas y
        l.d f6,0(r5)     ; cargas x
        mul.d f8,f6,f0   ; mult x * a  
        add.d f4,f8,f2   ; suma aX + y
        s.d f4, 0(r2)
        dadd r1,r1,#8
        dsub r4,r3,r1
        dadd r2,r2,#8
        dadd r5,r5,#8
        bnez r4,loop

        trap #0


        


