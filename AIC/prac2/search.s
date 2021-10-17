; cont = 0;
; for (i = 0; i < n; i++) {
;    if (a[i] == 0) {
;        cont = cont + 1;
;     }
; }


        .data
a:      .dword 9,8,0,1,0,5,3,1,2,0
tam:    .dword 10       ; Tamaño del vector
cont:   .dword 0        ; Número de componentes == 0

        .text
start:	dadd r1, $gp, a   ; Puntero
        ld r4, tam($gp)   ; Tamaño lista
        dadd r10, r0, r0  ; Contador de ceros
 
loop:   ld r12, 0(r1) 
        dsubi r4, r4, 1
	bnez r12, if 

        daddi r10, r10, 1

if:     
        daddi r1, r1, 8
        bnez r4, loop
        sd r10, cont($gp)
        trap #0