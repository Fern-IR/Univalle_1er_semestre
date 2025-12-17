using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        int limite = 10;
        float[] Notas = new float[limite];
        int cantidad, indice;
        Console.WriteLine("Introducir la cantidad de notas");
        cantidad = Convert.ToInt16(Console.ReadLine());
        indice = 0;
        float valor;
        while (indice < cantidad)
        {
            Console.WriteLine("Introducir un valor de nota:");
            valor = Convert.ToSingle(Console.ReadLine());
            Notas[indice] = valor;
            indice = indice + 1;
        }
        indice = 0;
        while (indice < cantidad)
        {
            Console.WriteLine(Notas[indice]);
            indice = indice + 1;
        }
        indice = 0;
        float suma = 0;
        while (indice < cantidad)
        {
            suma = suma + Notas[indice];
            indice = indice + 1;
        }
        Console.WriteLine("La sumatoria es:" + suma);
        Console.WriteLine("El promedio es:" + suma / cantidad);
    }
}