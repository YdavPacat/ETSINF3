(defglobal ?*nod-gen* = 0)
(defglobal ?*prof* = 60)

(deffacts grid
	(limites 5 8)
	(contenedor 1 5)
	(contenedor 1 3)
	(contenedor 2 1)
	(contenedor 4 5)
	(contenedor 4 3)
	(contenedor 6 1)
	(contenedor 7 5)
	(contenedor 8 3)
	(contenedor 8 1)
	(juego robot 2 3 latas l 3 3 l 3 1 l 6 4 nivel 0)
)

(deffunction inicio ()
	(reset)
	(printout t "Profundidad Maxima:= " )
	(bind ?*prof* (read))
	(printout t "Tipo de Búsqueda " crlf "1.- Anchura" crlf
 		    "2.- Profundidad" crlf )
	(bind ?a (read))
	(if (= ?a 1)
		then (set-strategy breadth)
 		else (set-strategy depth)))
)

(defrule robot_diag_derecha_arriba
	(juego robot ?x ?y latas $?z nivel ?nivel)
	(limites ?lim_x ?lim_y)
	(test (not (member$ (create$ l (+ ?x 1) (+ ?y 1)) $?z)))    ;; hay una lata en la diagonal?
	(not (contenedor =(+ ?x 1) =(+ ?y 1)))			     ;; hay un contenedor en la diagonal?
	(test (<> ?x ?lim_x))					     ;; está el robot en el limite de la derecha?
	(test (<> ?y ?lim_y))					     ;; está el robot en el limite superior?
	(test (< ?nivel ?*proof*))
=> 
	(bind ?*nod-gen* (+ ?*nod-gen* 1))
	(assert (juego robot (+ ?x 1) (+ ?y 1) latas $?z nivel (+ ?nivel 1)))
)

(defrule robot_diag_izquierda_arriba
	(juego robot ?x ?y latas $?z nivel ?nivel)
	(limites ?lim_x ?lim_y)
	(test (not (member$ (create$ l (- ?x 1) (+ ?y 1)) $?z)))    ;; hay una lata en la diagonal?
	(not (contenedor =(- ?x 1) =(+ ?y 1)))			     ;; hay un contenedor en la diagonal?
	(test (<> ?x 1))					     ;; está el robot en el limite de la derecha?
	(test (<> ?y ?lim_y))					     ;; está el robot en el limite superior?
	(test (< ?nivel ?*proof*))
=> 
	(bind ?*nod-gen* (+ ?*nod-gen* 1))
	(assert (juego robot (- ?x 1) (+ ?y 1) latas $?z nivel (+ ?nivel 1)))
)

(defrule robot_diag_derecha_abajo
	(juego robot ?x ?y latas $?z nivel ?nivel)
	(limites ?lim_x ?lim_y)
	(test (not (member$ (create$ l (+ ?x 1) (- ?y 1)) $?z)))     ;; hay una lata en la diagonal?
	(not (contenedor =(+ ?x 1) =(- ?y 1)))			     ;; hay un contenedor en la diagonal?
	(test (<> ?x ?lim_x))					     ;; está el robot en el limite de la derecha?
	(test (<> ?y ?lim_y))					     ;; está el robot en el limite superior?
	(test (< ?nivel ?*proof*))
=> 
	(bind ?*nod-gen* (+ ?*nod-gen* 1))
	(assert (juego robot (+ ?x 1) (- ?y 1) latas $?z nivel (+ ?nivel 1)))
)

(defrule robot_diag_izquierda_abajo
	(juego robot ?x ?y latas $?z nivel ?nivel)
	(limites ?lim_x ?lim_y)
	(test (not (member$ (create$ l (- ?x 1) (- ?y 1)) $?z)))      ;; hay una lata en la diagonal?
	(not (contenedor =(- ?x 1) =(- ?y 1)))			     ;; hay un contenedor en la diagonal?
	(test (<> ?x 1))					     ;; está el robot en el limite de la derecha?
	(test (<> ?y ?lim_y))					     ;; está el robot en el limite superior?
	(test (< ?nivel ?*proof*))
=> 
	(bind ?*nod-gen* (+ ?*nod-gen* 1))
	(assert (juego robot (- ?x 1) (- ?y 1) latas $?z nivel (+ ?nivel 1)))
)


;; Mover la lata


(defrule lata_diag_derecha_arriba
	(declare (salience 10))
	(juego robot ?x ?y latas $?z l ?w ?q $?r nivel ?nivel)
	(limites ?lim_x ?lim_y)
	(test (= ?x (+ ?w 1))						;; el robot y la lata están en el mismo eje X?
	(test (= ?y (+ ?q 1))						;; el robot y la lata están en el mismo eje Y?
	(test (<> ?w ?lim_x))						;; está la lata en el limite de la derecha?
	(test (<> ?q ?lim_y))						;; está la lata en el limite de arriba?
	(test (not (member$ (create$ l (+ ?x 2) (+ ?y 2)) $?z)))	;; hay una lata en la diagonal de la lata que voy a mover?
	(test (not (member$ (create$ l (+ ?x 2) (+ ?y 2)) $?r)))	;; hay una lata en la diagonal de la lata que voy a mover?
	(not (contenedor =(+ ?x 2) (+ ?y 2)))   			;; hay un contenedor a la derecha de la lata que voy a mover? 
	(test (< ?nivel ?*prof*))
=>
	(bind ?*nod-gen* (+ ?*nod-gen* 1))
	(assert (juego robot (+ ?x 1) (+ ?y 1) latas $?z l (+ ?w 1) (+ ?q 1) $?r nivel (+ ?nivel 1)))
)

(defrule lata_diag_izquierda_arriba
	(declare (salience 10))
	(juego robot ?x ?y latas $?z l ?w ?q $?r nivel ?nivel)
	(limites ?lim_x ?lim_y)
	(test (= ?x (- ?w 1))						;; el robot y la lata están en el mismo eje X?
	(test (= ?y (+ ?q 1))						;; el robot y la lata están en el mismo eje Y?
	(test (<> ?w 1))						;; está la lata en el limite de la izquierda?
	(test (<> ?q ?lim_y))						;; está la lata en el limite de arriba?
	(test (not (member$ (create$ l (- ?x 2) (+ ?y 2)) $?z)))	;; hay una lata en la diagonal de la lata que voy a mover?
	(test (not (member$ (create$ l (- ?x 2) (+ ?y 2)) $?r)))	;; hay una lata en la diagonal de la lata que voy a mover?
	(not (contenedor =(- ?x 2) (+ ?y 2)))   			;; hay un contenedor a la izquierda de la lata que voy a mover? 
	(test (< ?nivel ?*prof*))
=>
	(bind ?*nod-gen* (+ ?*nod-gen* 1))
	(assert (juego robot (- ?x 1) (+ ?y 1) latas $?z l (- ?w 1) (+ ?q 1) $?r nivel (+ ?nivel 1)))
)

(defrule lata_diag_derecha_abajo
	(declare (salience 10))
	(juego robot ?x ?y latas $?z l ?w ?q $?r nivel ?nivel)
	(limites ?lim_x ?lim_y)
	(test (= ?x (+ ?w 1))						;; el robot y la lata están en el mismo eje X?
	(test (= ?y (- ?q 1))						;; el robot y la lata están en el mismo eje Y?
	(test (<> ?w ?lim_x))						;; está la lata en el limite de la derecha?
	(test (<> ?q 1))						;; está la lata en el limite de abajo?
	(test (not (member$ (create$ l (+ ?x 2) (- ?y 2)) $?z)))	;; hay una lata en la diagonal de la lata que voy a mover?
	(test (not (member$ (create$ l (+ ?x 2) (- ?y 2)) $?r)))	;; hay una lata en la diagonal de la lata que voy a mover?
	(not (contenedor =(+ ?x 2) (- ?y 2)))   			;; hay un contenedor a abajo de la lata que voy a mover? 
	(test (< ?nivel ?*prof*))
=>
	(bind ?*nod-gen* (+ ?*nod-gen* 1))
	(assert (juego robot (+ ?x 1) (- ?y 1) latas $?z l (+ ?w 1) (- ?q 1) $?r nivel (+ ?nivel 1)))
)

(defrule lata_diag_izquierda_abajo
	(declare (salience 10))
	(juego robot ?x ?y latas $?z l ?w ?q $?r nivel ?nivel)
	(limites ?lim_x ?lim_y)
	(test (= ?x (- ?w 1))						;; el robot y la lata están en el mismo eje X?
	(test (= ?y (- ?q 1))						;; el robot y la lata están en el mismo eje Y?
	(test (<> ?w 1))						;; está la lata en el limite de la izquierda?
	(test (<> ?q 1))						;; está la lata en el limite de abajo?
	(test (not (member$ (create$ l (- ?x 2) (- ?y 2)) $?z)))	;; hay una lata en la diagonal de la lata que voy a mover?
	(test (not (member$ (create$ l (- ?x 2) (- ?y 2)) $?r)))	;; hay una lata en la diagonal de la lata que voy a mover?
	(not (contenedor =(- ?x 2) (- ?y 2)))   			;; hay un contenedor a abajo de la lata que voy a mover? 
	(test (< ?nivel ?*prof*))
=>
	(bind ?*nod-gen* (+ ?*nod-gen* 1))
	(assert (juego robot (- ?x 1) (- ?y 1) latas $?z l (- ?w 1) (- ?q 1) $?r nivel (+ ?nivel 1)))
)

;;tirar latas contenedores

(defrule tirar_lata_diag_derecha_arriba
	(declare (salience 20))
	(juego robot ?x ?y latas $?z l ?w ?q $?r nivel ?nivel)
	(limites ?lim_x ?lim_y)
	(test (= ?x (+ ?w 1)))						;; el robot y la lata comparten el mismo eje X?
	(test (= ?y (+ ?q 1)))						;; el robot y la lata comparten el mismo eje Y?
	(test (<> ?w ?lim_x))						;; está la lata en el limite de la derecha?
	(test (<> ?q ?lim_y)) 						;; está la lata en el limite superior?
	(contenedor =(+ ?x 2) (+ ?y 2))					;; hay un contenedor en la misma diagonal de la lata?
	(test (< ?nivel ?*prof*))
=>
	(bind ?*nod-gen* (+ ?*nod-gen* 1))
	(assert (juego robot (+ ?x 1) (+ ?y 1) latas $?z $?r nivel (+ ?nivel 1)))
)

(defrule tirar_lata_diag_izquierda_arriba
	(declare (salience 20))
	(juego robot ?x ?y latas $?z l ?w ?q $?r nivel ?nivel)
	(limites ?lim_x ?lim_y)
	(test (= ?x (- ?w 1)))						;; el robot y la lata comparten el mismo eje X?
	(test (= ?y (+ ?q 1)))						;; el robot y la lata comparten el mismo eje Y?
	(test (<> ?w 1))						;; está la lata en el limite de la izquierda?
	(test (<> ?q ?lim_y)) 						;; está la lata en el limite superior?
	(contenedor =(- ?x 2) (+ ?y 2))					;; hay un contenedor en la misma diagonal de la lata?
	(test (< ?nivel ?*prof*))
=>
	(bind ?*nod-gen* (+ ?*nod-gen* 1))
	(assert (juego robot (- ?x 1) (+ ?y 1) latas $?z $?r nivel (+ ?nivel 1)))
)

(defrule tirar_lata_diag_derecha_abajo
	(declare (salience 20))
	(juego robot ?x ?y latas $?z l ?w ?q $?r nivel ?nivel)
	(limites ?lim_x ?lim_y)
	(test (= ?x (+ ?w 1)))						;; el robot y la lata comparten el mismo eje X?
	(test (= ?y (- ?q 1)))						;; el robot y la lata comparten el mismo eje Y?
	(test (<> ?w ?lim_x))						;; está la lata en el limite de la derecha?
	(test (<> ?q 1)) 						;; está la lata en el limite inferior?
	(contenedor =(+ ?x 2) (- ?y 2))					;; hay un contenedor en la misma diagonal de la lata?
	(test (< ?nivel ?*prof*))
=>
	(bind ?*nod-gen* (+ ?*nod-gen* 1))
	(assert (juego robot (+ ?x 1) (- ?y 1) latas $?z $?r nivel (+ ?nivel 1)))
)

(defrule tirar_lata_diag_izquierda_abajo
	(declare (salience 20))
	(juego robot ?x ?y latas $?z l ?w ?q $?r nivel ?nivel)
	(limites ?lim_x ?lim_y)
	(test (= ?x (- ?w 1)))						;; el robot y la lata comparten el mismo eje X?
	(test (= ?y (- ?q 1)))						;; el robot y la lata comparten el mismo eje Y?
	(test (<> ?w 1))						;; está la lata en el limite de la izquierda?
	(test (<> ?q 1)) 						;; está la lata en el limite inferior?
	(contenedor =(- ?x 2) (- ?y 2))					;; hay un contenedor en la misma diagonal de la lata?
	(test (< ?nivel ?*prof*))
=>
	(bind ?*nod-gen* (+ ?*nod-gen* 1))
	(assert (juego robot (- ?x 1) (- ?y 1) latas $?z $?r nivel (+ ?nivel 1)))
)


(defrule objetivo
    (declare (salience 100))
    ?f <- (juego robot $?a latas nivel ?nivel)
=>
    (printout t "SOLUCION ENCONTRADA EN EL NIVEL " ?nivel crlf)
    (printout t "NODOS " ?*nod-gen* crlf)
    (printout t "HECHO OBJETIVO " ?f crlf)
    (halt)
)

(defrule no_solucion
    (declare (salience -99))
    ?f <- (juego robot $?a nivel ?nivel)
=>
    (printout t "SOLUCION NO ENCONTRADA" crlf)
    (printout t "NODOS GENERADOS " ?*nod-gen* crlf)
    (halt)
)