Algoritmo Ejercicio_basico_11
	Definir alumnos, i Como Entero;
    Definir nota_teorica, nota_practica, nota Como Real;
    
    // Solicitar número de alumnos (validando que sea >= 1)
    Repetir
        Escribir "Escribe el número de alumnos:";
        Leer alumnos;
        Si alumnos < 1 Entonces
            Escribir "Debe ser mayor o igual que 1";
        FinSi
    Hasta Que alumnos >= 1;
    
    // Procesar cada alumno
    Para i <- 1 Hasta alumnos Con Paso 1 Hacer
        // Validar nota teórica (0-10)
        Repetir
            Escribir "Introduce la nota teórica del alumno ", i, ":";
            Leer nota_teorica;
            Si no (nota_teorica >= 0 y nota_teorica <= 10) Entonces
                Escribir "Debes escribir un valor entre 0 y 10";
            FinSi
        Hasta Que nota_teorica >= 0 y nota_teorica <= 10;
        
        // Validar nota práctica (0-10)
        Repetir
            Escribir "Introduce la nota práctica del alumno ", i, ":";
            Leer nota_practica;
            Si no (nota_practica >= 0 y nota_practica <= 10) Entonces
                Escribir "Debes escribir un valor entre 0 y 10";
            FinSi
        Hasta Que nota_practica >= 0 y nota_practica <= 10;
        
        // Calcular nota final (60% teórica + 40% práctica)
        nota <- (nota_teorica * 0.6) + (nota_practica * 0.4);
        
        // Mostrar resultado
        Escribir "El alumno número ", i, " ha sacado una nota final de ", nota;
    FinPara
FinAlgoritmo
