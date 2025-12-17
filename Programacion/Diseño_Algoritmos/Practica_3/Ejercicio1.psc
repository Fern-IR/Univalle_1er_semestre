Algoritmo Ejercicio1
	Existencia = 1000
	Mientras Existencia>=200 Hacer
		Escribir "Centro de salud kolping"
		Leer Entrega
		Si Entrega<=Existencia Entonces
			Existencia = Existencia-Entrega
		SiNo
			Escribir "Cantidad Insuficiente"
		FinSi
		Escribir "Quedan:",Existencia
	FinMientras
	Escribir "Solicitar mas vacunas"
FinAlgoritmo
