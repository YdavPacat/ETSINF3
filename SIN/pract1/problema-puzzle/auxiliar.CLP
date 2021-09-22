;;COMPROBAR SI LA CONFIGURACION GENERADA TIENE SOLUCION
;;como usamos una configuracion final fija, esta siempre tiene valor 11
;;se cuenta, para cada valor, cuantos valores menores quedan a su derecha
;;se suman todos estos valores y debe dar un valor impar (para que inicial+final sea par)

(deffunction comprobar_conf (?list)
	(bind ?suma 0)
	(bind ?i 1)
        (bind ?list (replace-member$ ?list 9 0))   
	(while (<= ?i 9)
		(bind ?value (integer (nth 1 (subseq$ $?list ?i ?i))))
		;;(printout t ?value crlf)
		(bind ?cont 0)
		(bind ?j (+ 1 ?i))
		(while (<= ?j 9)
			(if (> ?value (integer (nth 1 (subseq$ $?list ?j ?j)))) then
				(bind ?cont (+ 1 ?cont))
			) 
			(bind ?j (+ 1 ?j))
		) 
		(bind ?suma (+ ?cont ?suma))
		(bind ?i (+ 1 ?i))
	)
        (bind ?pos_cero (member 9 ?list))	;;; EVA
        (bind ?row_cero (div ?pos_cero 3))	;;; EVA
        (bind ?col_cero (mod ?pos_cero 3))	;;; EVA
        (if (evenp (+ ?row_cero ?col_cero)) then (bind ?suma (+ ?suma 1)))	;;; EVA
	(<> (mod ?suma 2) 0)
) 