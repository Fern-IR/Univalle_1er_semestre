Algoritmo Ejercicio1
	Definir valor1,valor2,valor3 como entero
	Escribir 'Ingrese el primer valor:'
	Leer valor1
	Escribir 'Ingrese el segundo valor:'
	Leer valor2
	Escribir 'Ingrese el tercer valor:'
	Leer valor3
	mayor <- valor1
	menor <- valor1
	Si valor2>mayor Entonces
		mayor <- valor2
	FinSi
	Si valor2<menor Entonces
		menor <- valor2
	FinSi
	Si valor3>mayor Entonces
		mayor <- valor3
	FinSi
	Si valor3<menor Entonces
		menor <- valor3
	FinSi
	Escribir 'El mayor valor es:', mayor
	Escribir 'El menor valor es:', menor
FinAlgoritmo
