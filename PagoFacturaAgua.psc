Algoritmo PagoFacturaAgua
	definir montoOriginal, recargo, montotal Como Real;
	Definir diasRetraso Como Entero;
	
	Escribir "Ingrese el monto original de la factura($ - COD) ";
	leer montoOriginal;
	
	Escribir "Ingrese los dias de retraso en el pago: ";
	leer diasRetraso;
	
	montotal = montoOriginal;
	
	si diasRetraso > 5 Entonces
		recargo = montoOriginal * 0.05;
		montotal = montoOriginal + recargo;
		Escribir "Se aplicado un recargo del 5% ($",recargo, ") por mora.";
	FinSi
	 Escribir "Monto total definitivo a pagar:", montotal;
FinAlgoritmo
