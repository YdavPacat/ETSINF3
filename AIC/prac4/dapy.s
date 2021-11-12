        ; z = a + y
        ; Tamanyo de los vectores: 64 palabras
        ; Vector y
        .data
		
y:      .double 0.0, 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0
        .double 10.0,11.0,12.0,13.0,14.0,15.0,16.0,17.0,18.0,19.0
        .double 20.0,21.0,22.0,23.0,24.0,25.0,26.0,27.0,28.0,29.0
        .double 30.0,31.0,32.0,33.0,34.0,35.0,36.0,37.0,38.0,39.0
        .double 40.0,41.0,42.0,43.0,44.0,45.0,46.0,47.0,48.0,49.0
        .double 50.0,51.0,52.0,53.0,54.0,55.0,56.0,57.0,58.0,59.0

        ; Vector z
        ; 60 elementos son 480 bytes
z:      .space 480

        ; Escalar a
a:      .double 1.0

        .text
        ; El código

start:
        dadd r1,r0,y     ; r1 contiene la direccion de y
        dadd r2,r0,z     ; r2 contiene la direccion de z
        l.d f0,a(r0)     ; f0 contiene a
        dadd r3,r1,#480	 ; 60 elementos son 480 bytes
loop:
        l.d f2,0(r1)
        add.d f4,f0,f2
        s.d f4, 0(r2)
        dadd r1,r1,#8
        dsub r4,r3,r1
        dadd r2,r2,#8
        bnez r4,loop

        trap #0         ; Fin de programa
