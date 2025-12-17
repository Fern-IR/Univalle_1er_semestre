Algoritmo Ejercicio8
	Escribir 'Ingrese el primer número:'
	Leer numero
	maximo <- numero
	minimo <- numero
	i <- 1
	Mientras i<10 Hacer
		Escribir 'Ingrese el siguiente número:'
		Leer numero
		Si numero>maximo Entonces
			maximo <- numero
		FinSi
		Si numero<minimo Entonces
			minimo <- numero
		FinSi
		i <- i+1
	FinMientras
	Escribir 'El valor máximo es: ', maximo
	Escribir 'El valor mínimo es: ', minimo
FinAlgoritmo
