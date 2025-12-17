Algoritmo Ejercicio1
	Escribir 'Introduzca su nombre:'
	Leer Nombre
	Escribir 'Cantidad horas:'
	Leer CantidadHora
	Escribir 'Precio hora:'
	Leer PrecioHora
	SBruto <- CantidadHora*PrecioHora
	Impuesto <- SBruto*0.13
	SNeto <- SBruto-Impuesto
	Escribir 'Nombre:', Nombre
	Escribir 'Salario bruto:', SBruto
	Escribir 'Salario Neto:', SNeto
FinAlgoritmo
