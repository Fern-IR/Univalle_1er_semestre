Algoritmo sin_titulo
	Definir A,B,C como enteros
	Escribir "Ingresa 3 valores"
	Leer A,B,C
	Val = A+B+C
	Si Val>10 Entonces
		Escribir "xd"
	SiNo
		Repetir
			Escribir "Ingrese mas valores"
			Leer A,B,C
			Val = Val+A+B+C
		Hasta Que Val>=10
	FinSi
	Escribir "La suma es mayor a 10"
FinAlgoritmo
