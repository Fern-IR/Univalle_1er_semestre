internal class Program
{
    private static void Main(string[] args)
    {
        {
        Console.Write("Ingrese el valor del lado a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Ingrese el valor del lado b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Ingrese el valor del lado c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        
        if (a + b > c && a + c > b && b + c > a)
        {
            double p = (a + b + c) / 2;
            
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            
            Console.WriteLine($"El área del triángulo es: {area}");
        }
        else
        {
            Console.WriteLine("Los valores ingresados no forman un triángulo válido");
        }
    }
    }
}