using System;

class Program
{
    static void Main()
    {
        int suma = 0, contador = 1;

        do
        {
            Console.WriteLine("Ingrese el número"+contador);
            suma += int.Parse(Console.ReadLine());
            contador++;
        } while (contador <= 10);

        Console.WriteLine("La suma de los diez números es:"+suma);
    }
}
