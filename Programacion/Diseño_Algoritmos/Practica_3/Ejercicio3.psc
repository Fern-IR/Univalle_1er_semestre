Algoritmo Ejercicio
	Leer n
	Si N<=2 Entonces
		Escribir 1
	SiNo
		a = 1
		b = 1
		Repetir
			c = a+b
			a = b
			b = c
			n = n-1
		Hasta Que n=2
		Escribir b
	FinSi
FinAlgoritmo
