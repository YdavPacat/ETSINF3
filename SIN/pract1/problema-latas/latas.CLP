(defglobal ?*nod_gen* = 0)
(defglobal ?*prof* = 60)

(deffacts mapa
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

    (juego pos 7 3 latas l 3 3 l 3 1 l 6 4)
)

; (defrule mov_der
; 	?f <- (juego pos ?x ?y latas $?z)
;     (limites ?lim_x ?lim_y)
;     (hueco ?hue_x ?hue_y)
;     (test (<> (+ ?x 1) 0))
;     (not (hueco =(+ ?x 1) ?y ))
;     (test (not (member$ (create$ l(+ ?x 1) ?y) $?z)))
; =>
;     (bind ?*nod_gen* (+ ?*nod_gen* 1))
;     (assert (juego pos (+ ?x 1) ?y latas $?z))
; )

(defrule mov_izq
	?f <- (juego pos ?x ?y latas $?z)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> (- ?x 1) 0))
    (not (hueco =(- ?x 1) ?y ))
    (test (not (member$ (create$ l(- ?x 1) ?y) $?z)))
=>
    (bind ?*nod_gen* (+ ?*nod_gen* 1))
    (assert (juego pos (- ?x 1) ?y latas $?z))
)

; (defrule mov_aba
; 	?f <- (juego pos ?x ?y latas $?z)
;     (limites ?lim_x ?lim_y)
;     (hueco ?hue_x ?hue_y)
;     (test (<> (- ?y 1) 0))
;     (not (hueco =?x (- ?y 1)))
;     (test (not (member$ (create$ l ?x (- ?y 1) $?z)))
; =>
;     (bind ?*nod_gen* (+ ?*nod_gen* 1))
;     (assert (juego pos ?x (- ?y 1) latas $?z))
; )

; (defrule mov_arr
; 	?f <- (juego pos ?x ?y latas $?z)
;     (limites ?lim_x ?lim_y)
;     (hueco ?hue_x ?hue_y)
;     (test (<> (+ ?y 1) 0))
;     (not (hueco =?x (+ ?y 1)))
;     (test (not (member$ (create$ l ?x (+ ?y 1) $?z)))
; =>
;     (bind ?*nod_gen* (+ ?*nod_gen* 1))
;     (assert (juego pos ?x (+ ?y 1) latas $?z))
; )