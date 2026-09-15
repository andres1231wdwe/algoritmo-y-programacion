Algoritmo ControlVelocidad
	Definir velociadad Como real ;
	
Escribir "ingrese la velocidad registrada del vehiculo (km/H):";
	Leer velociadad;
	
	si velociadad > 80 Entonces
		Escribir "¡ALERTA! ha superado el limite de velocidad de 80 Km/h.";
		Escribir "Se ha generado una fotomulta automaticamente.";
	FinSi
	
	Escribir "Evaluacion de transito finalizada.";
FinAlgoritmo
