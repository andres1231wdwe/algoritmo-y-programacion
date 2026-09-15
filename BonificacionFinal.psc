Algoritmo BonificacionFinal
	definir unidadesVendidas, antiguedad Como Entero;
	Definir sueldoBase, bonificacion, sueldofinal Como Real;
	sueldoBase = 2200000
	bonificacion = 200000
	sueldofinal = sueldoBase
	
	Escribir "Ingrese la cantidad de unidades vendidas en el mes del trabajador: ";
	Leer unidadesVendida;
	Escribir "Ingrese los años de antiguedad en la empresa del trabajador: ";
	Leer antiguedad;
	
	si unidadesVendida > 50 y antiguedad > 2 Entonces
		sueldofinal = sueldoBase + bonificacion;
		Escribir "¡FELICIDADES! Ha cumplido con las metas de ventas, tienes una bonificacion de: $ ", bonificacion;
	FinSi
	Escribir "Tu salario este mes es de: $", sueldofinal;
	
FinAlgoritmo
