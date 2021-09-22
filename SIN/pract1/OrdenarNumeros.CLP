
  (deffacts datos
      (lista 4 5 3 46 12 10))

  (defrule ordenar
    ?f1 <- (lista $?x ?y ?z $?w)
	   (test (< ?z ?y))    ;; comprobamos si ?z es menor que ?y
	=>
	   (retract ?f1)
	   (assert (lista $?x ?z ?y $?w)))   ;; intercambiamos elementos


   
