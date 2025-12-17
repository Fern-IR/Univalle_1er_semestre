Algoritmo Calcular_diferentes_areas
	Repetir
		Escribir 'Seleccione la operación que desea realizar:'
		Escribir '1. Calcular el área de un triángulo'
		Escribir '2. Calcular el área de un rectángulo'
		Escribir '3. Calcular el área de un cuadrado'
		Escribir '4. Calcular el área de una circunferencia'
		Escribir '5. Salir'
		Leer opcion
		Si opcion=1 Entonces
			Escribir 'Ingrese la base del triángulo:'
			Leer base
			Escribir 'Ingrese la altura del triángulo:'
			Leer altura
			Escribir 'El área del triángulo es: ', (base*altura)/2
		SiNo
			Si opcion=2 Entonces
				Escribir 'Ingrese el largo del rectángulo:'
				Leer largo
				Escribir 'Ingrese el ancho del rectángulo:'
				Leer ancho
				Escribir 'El área del rectángulo es: ', largo*ancho
			SiNo
				Si opcion=3 Entonces
					Escribir 'Ingrese el lado del cuadrado:'
					Leer lado
					Escribir 'El área del cuadrado es: ', lado*lado
				SiNo
					Si opcion=4 Entonces
						Escribir 'Ingrese el radio de la circunferencia:'
						Leer radio
						Escribir 'El área de la circunferencia es: ', 3.1416*radio*radio
					SiNo
						Si opcion=5 Entonces
							Escribir "Saliendo"
						SiNo
							Escribir 'Elige un numero del 1 al 5, no mayor a 5 indio'
						FinSi
					FinSi
				FinSi
			FinSi
		FinSi
		Si opcion<>5 Entonces
			Escribir '¿Desea realizar otra operación? (S/N)'
			Leer continuar
		FinSi
	Hasta Que continuar='N' O continuar='n' O opcion=5
	Escribir 'Sos pichanga'
FinAlgoritmo
