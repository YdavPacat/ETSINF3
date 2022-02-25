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
        l.d f2, 0(r2)
        mul.d f0, f0, f2
        add.d f4, f0, f4
        daddi r1, r1, #8
        daddi r2, r2, #8
        daddi r3, r3, #-1
        sgt r5, r3, r0
        bnez r5, loop
        nop

        trap #0 