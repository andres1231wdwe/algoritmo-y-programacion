Algoritmo ValidadrAprobacion
	Definir nota Como Real
	
	Escribir "Ingrese la calificacion final obtenida (0.0 - 5.0).";
	Leer nota;
	
	si nota >=3.0 Entonces
		
		Escribir "¡Enhorabuena! Ha aprovado sastifactoriamente la asignatura.";
	FinSi
	
	
	si nota <=3.0 Entonces
		Escribir " No aprobo la asignatura "
	
	FinSi
	
	Escribir "Proceso de reporte de calificaciones finalizacion."

FinAlgoritmo
