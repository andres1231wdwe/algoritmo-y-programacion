Algoritmo AlertaTemperatura
	Definir  tem como real ;
	
	Escribir  "Ingrese la temperatura  actual en grados celsius (°C):";
	leer  tem;
	
	si tem < 0 Entonces
		Escribir "¡DVERTENCIA! Temperatura bajo cero detectada.";
		Escribir "Riesgo de congelamiento en carreteras.", "Conduza con precaucion";
		
	FinSi
	
	Escribir "registro meteorologico completado.";
FinAlgoritmo
