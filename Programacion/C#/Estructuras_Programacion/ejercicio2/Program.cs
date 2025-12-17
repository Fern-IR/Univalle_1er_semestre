using System;

class Program
{
    static void Main()
    {
        int n, contador = 0;
        double sumaEdades = 0;

        Console.WriteLine("Ingrese la cantidad de alumnos:");
        n = int.Parse(Console.ReadLine());

        do
        {
            Console.WriteLine($"Ingrese la edad del alumno"+contador + 1);
            sumaEdades += double.Parse(Console.ReadLine());
            contador++;
        } while (contador < n);

        double promedio = sumaEdades / n;
        Console.WriteLine("La edad promedio es:"+promedio);
    }
}