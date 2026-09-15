Algoritmo DescuentoEspecial
	Definir montoCompra, descuento, montoFinal Como Real;
	
	Escribir "ingrese el valor total de su compra ($):";
	Leer montoCompra;
	
	montoFinal = montoCompra;
	
	si montoCompra > 190 Entonces
		descuento = montoCompra * 0.10;
		montoFinal = montoCompra - descuento;
		Escribir  "¡Felicidades! Ha recicibido un descuento de: $", descuento;
	FinSi
	
	Escribir  "El total a pagar es: $", montoFinal
FinAlgoritmo
