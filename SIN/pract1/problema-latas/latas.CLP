(defglobal ?*nod_gen* = 0)
(defglobal ?*prof* = 60)


(deffacts mapa
    ;; Atributos estáticos
    (limites 8 5)
    (hueco 2 1)
    (hueco 6 1)
    (hueco 8 1)
    (hueco 1 3)
    (hueco 4 3)
    (hueco 8 3)
    (hueco 1 5)
    (hueco 4 5)
    (hueco 7 5)

    ;; Atributos dinámicos
    (problema pos 7 3 latas l 3 3 l 3 1 l 6 4)
)

(defrule mov_der
	?f <- (problema pos ?x ?y latas $?z)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?x ?lim_x))
    (not (hueco =(+ ?x 1) ?y ))
    (test (not (member$ (create$ l(+ ?x 1) ?y) $?z)))
=>
    (bind ?*nod_gen* (+ ?*nod_gen* 1))
    (assert (problema pos (+ ?x 1) ?y latas $?z))
)

(defrule mov_izq
	?f <- (problema pos ?x ?y latas $?z)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?x 1))
    (not (hueco =(- ?x 1) ?y ))
    (test (not (member$ (create$ l(- ?x 1) ?y) $?z))); No se mueva hacia la lata
=>
    (bind ?*nod_gen* (+ ?*nod_gen* 1))
    (assert (problema pos (- ?x 1) ?y latas $?z))
)

(defrule mov_aba
	?f <- (problema pos ?x ?y latas $?z)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?y 1))
    (not (hueco ?x =(- ?y 1)))
    (test (not (member$ (create$ l ?x (- ?y 1)) $?z)))
=>
    (bind ?*nod_gen* (+ ?*nod_gen* 1))
    (assert (problema pos ?x (- ?y 1) latas $?z))
)

(defrule mov_arr
	?f <- (problema pos ?x ?y latas $?z)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?y ?lim_y))
    (not (hueco ?x =(+ ?y 1)))
    (test (not (member$ (create$ l ?x (+ ?y 1)) $?z)))
=>
    (bind ?*nod_gen* (+ ?*nod_gen* 1))
    (assert (problema pos ?x (+ ?y 1) latas $?z))
)

(defrule mov_lata_arr
    ?f <- (problema pos ?x ?y latas $?z l ?l_x ?l_y $?w)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?l_y ?lim_y))
    ; (not (hueco ?l_x =(+ ?l_y 1)))
    (test (and (= ?l_x ?x) (= ?l_y (+ ?y 1))))
=>
    (bind ?*nod_gen* (+ ?*nod_gen* 1))
    (assert (problema pos ?x (+ ?y 1) latas $?z l ?l_x (+ ?l_y 1) $?w))
)

(defrule mov_lata_aba
    ?f <- (problema pos ?x ?y latas $?z l ?l_x ?l_y $?w)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?l_y 1))
    ; (not (hueco ?l_x =(- ?l_y 1)))
    (test (and (= ?l_x ?x) (= ?l_y (- ?y 1))))
=>
    (bind ?*nod_gen* (+ ?*nod_gen* 1))
    (assert (problema pos ?x (- ?y 1) latas $?z l ?l_x (- ?l_y 1) $?w))
)

(defrule mov_lata_der
    ?f <- (problema pos ?x ?y latas $?z l ?l_x ?l_y $?w)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?l_x ?lim_x))
    ; (not (hueco =(+ ?l_x 1) ?l_y))
    (test (and (= (+ ?l_x 1) ?x) (= ?l_y ?y)))
=>
    (bind ?*nod_gen* (+ ?*nod_gen* 1))
    (assert (problema pos (+ ?x 1) ?y latas $?z l (+ ?l_x 1) ?l_y $?w))
)

(defrule mov_lata_izq
    ?f <- (problema pos ?x ?y latas $?z l ?l_x ?l_y $?w)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?l_y 1))
    ; (not (hueco =(- ?l_x 1) ?l_y))
    (test (and (= (- ?l_x 1) ?x) (= ?l_y ?y)))
=>
    (bind ?*nod_gen* (+ ?*nod_gen* 1))
    (assert (problema pos (- ?x 1) ?y latas $?z l (- ?l_x 1) ?l_y $?w))
)

(defrule tirar_lata_arr
    ?f <- (problema pos ?x ?y latas $?z l ?l_x ?l_y $?w)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?l_y ?lim_y))
    (test (and (= ?hue_x ?l_x) (= ?hue_y (+ ?l_y 1))))
=>
    (assert (problema pos ?x ?y latas $?z $?w))
)

(defrule tirar_lata_aba
    ?f <- (problema pos ?x ?y latas $?z l ?l_x ?l_y $?w)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?l_y 1))
    (test (and (= ?hue_x ?l_x) (= ?hue_y (- ?l_y 1))))
=>
    (assert (problema pos ?x ?y latas $?z $?w))
)
(defrule tirar_lata_der
    ?f <- (problema pos ?x ?y latas $?z l ?l_x ?l_y $?w)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?l_x ?lim_x))
    (test (and (= ?hue_x (+ ?l_x 1)) (= ?hue_y ?l_y)))
=>
    (assert (problema pos ?x ?y latas $?z $?w))
)
(defrule tirar_lata_izq
    ?f <- (problema pos ?x ?y latas $?z l ?l_x ?l_y $?w)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?l_y 1))
    (test (and (= ?hue_x (- ?l_x 1)) (= ?hue_y ?l_y)))
=>
    (assert (problema pos ?x ?y latas $?z $?w))
)
