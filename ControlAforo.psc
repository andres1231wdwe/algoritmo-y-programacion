Algoritmo ControlAforo
	Definir asistentes, exceso Como Entero;
	
	Escribir " ingrese la cantidad de asisitentes confirmados:";
	leer asistentes; 
	
	si asistentes > 150 Entonces
		exceso = asistentes - 150;
		Escribir "¡Alerta! se ha excedido la cantidad maxima de la sala.";
		Escribir "Hay ", exceso, " Persona(S) por encima de limite permitido.";
	FinSi
	
	Escribir "Registro de aforo concluido."; 
	
FinAlgoritmo
