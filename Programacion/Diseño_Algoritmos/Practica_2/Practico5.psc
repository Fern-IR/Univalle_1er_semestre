Algoritmo Practico5
	Escribir 'Ingrese cuatro numeros enteros'
	Leer A, B, C, D
	Si A>=B Entonces
		Si A>=C Entonces
			Si A>=D Entonces
				Escribir 'El mayor es:', A
				Escribir 'El menor es:', D
			SiNo
				Escribir 'El mayor es:', D
				Escribir 'El menor es:', A
			FinSi
		SiNo
			Si A<=D Entonces
				Escribir 'El mayor es:', D
				Escribir 'El menor es:', A
			SiNo
				Escribir "El mayor es:",A
				Escribir "El menor es:",D
			FinSi
		FinSi
	SiNo
		Si B>=C Entonces
			Si B>=D Entonces
				Escribir 'El mayor es:', B
				Escribir 'El menor es:', D
			SiNo
				Escribir "El mayor es:",D
				Escribir "El menor es:",B
			FinSi
		SiNo
			Si B<=D Entonces
				Escribir 'El mayor es:', D
				Escribir 'El menor es:', B
			SiNo
				Escribir "El mayor es:",B
				Escribir "El menor es:",D
			FinSi
		FinSi
	FinSi
FinAlgoritmo
