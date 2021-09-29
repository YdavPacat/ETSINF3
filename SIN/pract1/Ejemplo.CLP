
(deffacts mapa
    (limites 1 11)
    (hueco 3 3)
    (hueco 3 3)
    (hueco 8 3)
    (hueco 5 2)
    (hueco 4 4)
    (hueco 5 4)
    (hueco 6 4)
    (escalera 3 1)
    (escalera 2 2 )
    (escalera 1 3 )
    (escalera 10 2)
    (escalera 7 1)
    (escalera 7 3)
    (escalera 11 3)
    (juego pos 1 1 enemigos e 4 2 e 8 2 e 8 4 objetos o 4 3 o 3 4 o 11 2 disparos 2 nivel 0)

)

(defrule derecha
    (juego pos ?x ?y enemigos $?w objetos $?z nivel ?n)
    (limites ? ?b)
    (test (not (member$ (create$ e (+ ?x 1) ?y) $?w)))
    (not (hueco =(+ ?x 1) ?y ))
    (test (< ?x ?b)) 2
    (profundidad‐maxima ?prof)
    (test (< ?n ?prof))
    =>
    (bind ?*nod‐gen* (+ ?*nod‐gen* 1))
    (assert (juego pos (+ ?x 1) ?y enemigos $?w objetos ?z nivel (+ ?n 1)))
)

(defrule subir
    (juego pos ?x ?y $?z nivel ?n)
    (escalera ?x ?y)
    (profundidad‐maxima ?prof) 2
    (profundidad maxima ?prof)
    (test (< ?n ?prof))
    =>
    (bind ?*nod‐gen* (+ ?*nod‐gen* 1))
    1
    1 2 3 4 5 6 7 8
    ( g ( g ))
    (assert (juego pos ?x (+ ?y 1) ?z  nivel (+ ?n 1)))
)