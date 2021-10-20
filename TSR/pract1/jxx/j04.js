
//Uso de operaciones asíncronas, aquí modeladas con la función setTimeout.
//Note el valor de i asociado a las ejecuciones de las temporizaciones.

for(var i=0; i<10; i++) 
   setTimeout(function(x){return () => {console.log(x)}}(i),i*1000);


console.log("Terminado codigo script  valor actual de i: ",i);
