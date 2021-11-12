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
        l.d f2,0(r1)           ; cargas y
        l.d f10,8(r1)          ; cargas y
        l.d f18,16(r1)         ; cargas y
        l.d f26,24(r1)         ; cargas y
        l.d f3, 32(r1)         ; cargas y
        l.d f11, 40(r1)        ; cargas y

        l.d f6,0(r5)           ; cargas x
        l.d f14,8(r5)          ; cargas x
        l.d f22,16(r5)         ; cargas x
        l.d f30,24(r5)         ; cargas x
        l.d f7, 32(r5)         ; cargas x
        l.d f15, 40(r5)         ; cargas x

        mul.d f8,f6,f0        ; mult x * a  
        mul.d f16,f14,f0      ; mult x * a  
        mul.d f24,f22,f0      ; mult x * a  
        mul.d f1 ,f30,f0      ; mult x * a  
        mul.d f9 ,f7,f0      ; mult x * a  
        mul.d f17 ,f15,f0      ; mult x * a  

        add.d f4,f8,f2        ; suma aX + y
        add.d f12,f16,f10     ; suma aX + y
        add.d f20,f24,f18     ; suma aX + y
        add.d f28,f1,f26      ; suma aX + y
        add.d f5 ,f9,f3      ; suma aX + y
        add.d f13 ,f17,f11      ; suma aX + y

        s.d f4,  0(r2)
        s.d f12, 8(r2)
        s.d f20, 16(r2)
        s.d f28, 24(r2)
        s.d f5,  32(r2)

        dadd r1,r1,#48
        dsub r4,r3,r1
        dadd r2,r2,#48
        dadd r5,r5,#48
        bnez r4,loop

        trap #0


        


