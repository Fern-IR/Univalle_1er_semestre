Algoritmo Ejercicio_basico_10
	Repetir
		Escribir "Escribe N"
		leer n
		
		si n<1 Entonces
			Escribir "Debe ser mayor que 1"
		FinSi
	Hasta Que n>0
	resultado=0
	Para i<-1 Hasta n Con Paso 1 Hacer
		resultado=1^2
		Escribir "El valor al cuadrado de ",i," es de",resultado
	FinPara
FinAlgoritmo
