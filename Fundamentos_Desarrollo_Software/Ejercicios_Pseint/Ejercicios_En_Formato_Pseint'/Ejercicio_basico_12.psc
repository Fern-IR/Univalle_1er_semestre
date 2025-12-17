Algoritmo Ejercicio_basico_12
	Definir horas, minutos, segundos Como Entero;
    Definir limite Como Entero;
    
    horas <- 0;
    minutos <- 0;
    segundos <- 0;
    limite <- 5; // Segundos de ejecución (cambiable)
	
    Mientras segundos < limite Hacer // Bucle con condición de salida
        Si horas < 10 Entonces
            Escribir "0",horas Sin Saltar;
        Sino
            Escribir horas Sin Saltar;
        FinSi
        
        Escribir ":" Sin Saltar;
        
        Si minutos < 10 Entonces
            Escribir "0",minutos Sin Saltar;
        Sino
            Escribir minutos Sin Saltar;
        FinSi
        
        Escribir ":" Sin Saltar;
        
        Si segundos < 10 Entonces
            Escribir "0",segundos;
        Sino
            Escribir segundos;
        FinSi
        
        segundos <- segundos + 1;
        
        Si segundos = 60 Entonces
            segundos <- 0;
            minutos <- minutos + 1;
        FinSi
        
        Si minutos = 60 Entonces
            minutos <- 0;
            horas <- horas + 1;
        FinSi
        
        Esperar 1 segundos
    FinMientras
FinAlgoritmo
