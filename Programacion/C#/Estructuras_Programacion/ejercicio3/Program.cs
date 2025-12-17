using System;

class Program
{
    static void Main()
    {
        double ahorroTotal = 0;

        for (int mes = 1; mes <= 12; mes++)
        {
            Console.WriteLine("Ingrese el ahorro del mes");
            double ahorroMensual = double.Parse(Console.ReadLine());
            ahorroTotal += ahorroMensual;
            Console.WriteLine("Ahorro acumulado hasta el mes mes:"+ahorroTotal);
        }

        Console.WriteLine("El ahorro total al final del año es:"+ahorroTotal);
    }
}
