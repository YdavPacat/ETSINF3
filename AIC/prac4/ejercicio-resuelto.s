        .data
y:      .double 0,1,2,3,4,5,6,7,8,9
        .double 10,11,12,13,14,15,16,17,18,19
        .double 20,21,22,23,24,25,26,27,28,29
        .double 30,31,32,33,34,35,36,37,38,39
        .double 40,41,42,43,44,45,46,47,48,49
        .double 50,51,52,53,54,55,56,57,58,59
        .double 60,61,62,63

x:      .double 0,1,2,3,4,5,6,7,8,9
        .double 10,11,12,13,14,15,16,17,18,19
        .double 20,21,22,23,24,25,26,27,28,29
        .double 30,31,32,33,34,35,36,37,38,39
        .double 40,41,42,43,44,45,46,47,48,49
        .double 50,51,52,53,54,55,56,57,58,59
        .double 60,61,62,63

     .text
start: 
    daddi r1, r0, y
    daddi r2, r0, x 
    daddi r3, r0, #64

loop: 
    l.d f0, 0(r1)
    l.d f1, 8(r1)
    l.d f2, 16(r1)
    l.d f3, 24(r1)

    l.d f4, 0(r2)
    l.d f5, 8(r2)
    l.d f6, 16(r2) 
    l.d f7, 24(r2)

    mul.d f0, f0, f4
    mul.d f1, f1, f5
    mul.d f2, f2, f6
    mul.d f3, f3, f7

    add.d f8, f0, f8
    daddi r3, r3, #-4 
    add.d f8, f1, f8
    sgt r5, r3, r0 
    add.d f8, f2, f8
    daddi r1, r1, #32
    add.d f8, f3, f8

    bnez r5, loop
    daddi r2, r2, #32

    trap #0  ; fin programa