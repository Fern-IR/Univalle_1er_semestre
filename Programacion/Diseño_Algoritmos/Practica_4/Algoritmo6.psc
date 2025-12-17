Algoritmo Ejercicio6
	n <- 100
	i <- 1
	Escribir 'Ingrese el primer número:'
	Leer maximo
	Mientras i<n Hacer
		Escribir 'Ingrese el siguiente número:'
		Leer numeros
		Si numeros>maximo Entonces
			maximo <- numeros
		FinSi
		i <- i+1
	FinMientras
	Escribir 'El valor máximo es: ', maximo
FinAlgoritmo
