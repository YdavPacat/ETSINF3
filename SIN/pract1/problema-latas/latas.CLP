(defglobal ?*nod-gen* = 0)
(defglobal ?*prof* = 15)
; (defglobal ?*busq* = 2)

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
    (problema pos 2 3 latas l 3 3 l 3 1 l 6 4 prof 0)
)

(deffunction inicio ()
    (reset)
    (printout T"Profundidad maxima= ")
    (bind ?*prof* (read))
    (printout T"Tipo de busqueda " crlf "1.-Anchura" crlf "2.-Profundidad" crlf)
    (bind ?busq (read))
    (if (= ?busq 1)
        then (set-strategy breadth)
        else (set-strategy depth)
    )
)

(defrule mov_der
	?f <- (problema pos ?x ?y latas $?z prof ?nivel) 
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?x ?lim_x))
    (not (hueco =(+ ?x 1) ?y ))
    (test (not (member$ (create$ l(+ ?x 1) ?y) $?z)))
    (test (< ?nivel ?*prof*))
=>
    (bind ?*nod-gen* (+ ?*nod-gen* 1))
    (assert (problema pos (+ ?x 1) ?y latas $?z prof (+ ?nivel 1)))
)

(defrule mov_izq
	?f <- (problema pos ?x ?y latas $?z prof ?nivel)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?x 1))
    (not (hueco =(- ?x 1) ?y ))
    (test (not (member$ (create$ l(- ?x 1) ?y) $?z))); No se mueva hacia la lata
    (test (< ?nivel ?*prof*))
=>
    (bind ?*nod-gen* (+ ?*nod-gen* 1))
    (assert (problema pos (- ?x 1) ?y latas $?z prof (+ ?nivel 1)))
)

(defrule mov_aba
	?f <- (problema pos ?x ?y latas $?z prof ?nivel)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?y 1))
    (not (hueco ?x =(- ?y 1)))
    (test (not (member$ (create$ l ?x (- ?y 1)) $?z)))
    (test (< ?nivel ?*prof*))
=>
    (bind ?*nod-gen* (+ ?*nod-gen* 1))
    (assert (problema pos ?x (- ?y 1) latas $?z prof(+ ?nivel 1)))
)

(defrule mov_arr
	?f <- (problema pos ?x ?y latas $?z prof ?nivel)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?y ?lim_y))
    (not (hueco ?x =(+ ?y 1)))
    (test (not (member$ (create$ l ?x (+ ?y 1)) $?z)))
    (test (< ?nivel ?*prof*))
=>
    (bind ?*nod-gen* (+ ?*nod-gen* 1))
    (assert (problema pos ?x (+ ?y 1) latas $?z prof (+ ?nivel 1)))
)

(defrule mov_lata_arr
    ?f <- (problema pos ?x ?y latas $?z l ?l_x ?l_y $?w prof ?nivel)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y) 
    (test (<> ?l_y ?lim_y))                     ;; ¿La lata está ya arriba del todo?
    (test (<> ?y ?lim_y))                     
    (not (hueco ?l_x =(+ ?l_y 1)))              ;; ¿Hay un hueco después de la lata?
    (test (and (= ?l_x ?x) (= ?l_y (+ ?y 1))))  ;; ¿La lata está arriba del robor?
    (test (< ?nivel ?*prof*))
=>
    (bind ?*nod-gen* (+ ?*nod-gen* 1))
    (assert (problema pos ?x (+ ?y 1) latas $?z l ?l_x (+ ?l_y 1) $?w prof (+ ?nivel 1)))
)

(defrule mov_lata_aba
    ?f <- (problema pos ?x ?y latas $?z l ?l_x ?l_y $?w prof ?nivel)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?y 1))
    (test (<> ?l_y 1))
    (not (hueco ?l_x =(- ?l_y 1)))
    (test (and (= ?l_x ?x) (= ?l_y (- ?y 1))))
    (test (< ?nivel ?*prof*))
=>
    (bind ?*nod-gen* (+ ?*nod-gen* 1))
    (assert (problema pos ?x (- ?y 1) latas $?z l ?l_x (- ?l_y 1) $?w prof (+ ?nivel 1)))
)

(defrule mov_lata_der
    ?f <- (problema pos ?x ?y latas $?z l ?l_x ?l_y $?w prof ?nivel)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?x ?lim_x))
    (test (<> ?l_x ?lim_x))
    (not (hueco =(+ ?l_x 1) ?l_y))
    (test (and (= (+ ?l_x 1) ?x) (= ?l_y ?y)))
    (test (< ?nivel ?*prof*))
=>
    (bind ?*nod-gen* (+ ?*nod-gen* 1))
    (assert (problema pos (+ ?x 1) ?y latas $?z l (+ ?l_x 1) ?l_y $?w prof (+ ?nivel 1)))
)

(defrule mov_lata_izq
    ?f <- (problema pos ?x ?y latas $?z l ?l_x ?l_y $?w prof ?nivel)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?x 1))
    (test (<> ?l_y 1))
    (not (hueco =(- ?l_x 1) ?l_y))
    (test (and (= (- ?l_x 1) ?x) (= ?l_y ?y)))
    (test (< ?nivel ?*prof*))
=>
    (bind ?*nod-gen* (+ ?*nod-gen* 1))
    (assert (problema pos (- ?x 1) ?y latas $?z l (- ?l_x 1) ?l_y $?w prof (+ ?nivel 1)))
)

(defrule tirar_lata_arr
    (declare (salience 20))
    ?f <- (problema pos ?x ?y latas $?z l ?l_x ?l_y $?w prof ?nivel)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?l_y ?lim_y))
    (test (and (= ?hue_x ?l_x) (= ?hue_y (+ ?l_y 1)))) ;; ¿Arriba de la lata hay un hueco?
    (test (and (= ?l_x ?x) (= ?l_y (+ ?y 1))))         ;; ¿La lata está arriba del robor?
    (test (< ?nivel ?*prof*))
=>
    (bind ?*nod-gen* (+ ?*nod-gen* 1))
    (assert (problema pos ?x (+ ?y 1) latas $?z $?w prof (+ ?nivel 1)))
)

(defrule tirar_lata_aba
    (declare (salience 20))
    ?f <- (problema pos ?x ?y latas $?z l ?l_x ?l_y $?w prof ?nivel)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?l_y 1))
    (test (and (= ?hue_x ?l_x) (= ?hue_y (- ?l_y 1)))) 
    (test (and (= ?l_x ?x) (= ?l_y (- ?y 1)))) 
    (test (< ?nivel ?*prof*))
=>
    (bind ?*nod-gen* (+ ?*nod-gen* 1))
    (assert (problema pos ?x (- ?y 1) latas $?z $?w prof (+ ?nivel 1)))
)
(defrule tirar_lata_der
    (declare (salience 20))
    ?f <- (problema pos ?x ?y latas $?z l ?l_x ?l_y $?w prof ?nivel)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?l_x ?lim_x))
    (test (and (= ?hue_x (+ ?l_x 1)) (= ?hue_y ?l_y)))
    (test (and (= ?l_x (+ ?x 1)) (= ?l_y ?y)))
    (test (< ?nivel ?*prof*))
=>
    (bind ?*nod-gen* (+ ?*nod-gen* 1))
    (assert (problema pos (+ ?x 1) ?y latas $?z $?w prof (+ ?nivel 1)))
)
(defrule tirar_lata_izq
    (declare (salience 20))
    ?f <- (problema pos ?x ?y latas $?z l ?l_x ?l_y $?w prof ?nivel)
    (limites ?lim_x ?lim_y)
    (hueco ?hue_x ?hue_y)
    (test (<> ?l_y 1))
    (test (and (= ?hue_x (- ?l_x 1)) (= ?hue_y ?l_y)))
    (test (and (= ?l_x (- ?x 1)) (= ?l_y ?y)))
    (test (< ?nivel ?*prof*))
=>
    (bind ?*nod-gen* (+ ?*nod-gen* 1))
    (assert (problema pos (- ?x 1) ?y latas $?z $?w prof (+ ?nivel 1)))
)

(defrule fin
    (declare (salience 100))
    ?f <- (problema $?a latas prof ?nivel)
    (problema pos ?x ?y latas)
=>
    (printout T"Fin" crlf)
    (printout T"Solución encontrada en el nivel: " ?nivel crlf)
    (printout T"Nodos: " ?*nod-gen* crlf)
    (printout T"Hecho objetivo: " ?f crlf)
    (halt)
)

(defrule no_solucion
    (declare (salience -100))
    ?f <- (problema $?a prof ?nivel)
=>
    (printout T"Solucion no encontrada" crlf)
    (printout T"Nodos expandidos: " ?*nod-gen* crlf)
    (halt)
)