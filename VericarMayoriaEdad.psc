Algoritmo VericarMayoriaEdad
	Escribir "Ingrese el año actual:"
	leer anioActual
	Escribir "ingrese su año de nacimiento:"
	leer anioNacimiento 
	edad = anioActual - anioNacimiento 
	si edad >= 18 Entonces
		Escribir "es mayor de edad. edad:", edad 
	sino 
		Escribir "es menor de edad. Edad:", edad
	FinSi	
FinAlgoritmo
