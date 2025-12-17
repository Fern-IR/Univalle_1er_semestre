Algoritmo Ejercicio5
	Escribir "Ingrese dividendo (Tiene que ser mayor al divisor)"
	Leer Dividendo
	Escribir "Ingrese divisor"
	Leer Divisor
	contador = 0
	Resto = Dividendo
	Repetir
		Resto = Resto-Divisor
		Contador = Contador+1
	Hasta Que Resto<Divisor
	Escribir "El cociente es:",Contador
	Escribir "El resto es:",Resto
FinAlgoritmo
