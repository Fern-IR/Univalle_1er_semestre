internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese el valor de a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        if (a != 0)
        {
            double x = -b / a;
            Console.WriteLine($"La solución es x = {x}");
        }
        else if (b != 0)
        {
            Console.WriteLine("La ecuación no tiene solución (solución imposible)");
        }
        else
        {
            Console.WriteLine("La ecuación tiene infinitas soluciones (solución indeterminada)");
        }
    }
 }       