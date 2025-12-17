using System;

class Program
{
    static void Main()
    {
        double[] horasPorDia = new double[6];
        double totalHoras = 0;
        double sueldoPorHora, sueldoTotal;
        
        Console.WriteLine("Cálculo de horas trabajadas y sueldo semanal");
        
        Console.Write("Ingrese el sueldo por hora del empleado: ");
        sueldoPorHora = Convert.ToDouble(Console.ReadLine());
        
        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Ingrese las horas trabajadas el día {i + 1}: ");
            horasPorDia[i] = Convert.ToDouble(Console.ReadLine());
            totalHoras += horasPorDia[i];
        }
        
        sueldoTotal = totalHoras * sueldoPorHora;
        
        Console.WriteLine("\nResumen semanal:");
        Console.WriteLine($"Total de horas trabajadas: {totalHoras} horas");
        Console.WriteLine($"Sueldo por hora: ${sueldoPorHora:N2}");
        Console.WriteLine($"Sueldo total de la semana: ${sueldoTotal:N2}");
        
        Console.WriteLine("Presione cualquier tecla para salir");
        Console.ReadKey();
    }
}
