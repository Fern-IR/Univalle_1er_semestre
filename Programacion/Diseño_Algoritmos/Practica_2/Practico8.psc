Algoritmo Practico8
	contador_impares <- 0
	suma_impares <- 0
	numero <- 1
	Mientras numero<=300 Hacer
		Si numero MOD 2<>0 Entonces
			contador_impares <- contador_impares+1
			suma_impares <- suma_impares+numero
		FinSi
		numero <- numero+1
	FinMientras
	Escribir 'Cantidad de números impares: ', contador_impares
	Escribir 'Sumatoria de los números impares: ', suma_impares
FinAlgoritmo
