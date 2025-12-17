internal class Program
{
 static void Main()
    {
        int I = 10; 
        int S = 0; 
        int A;      
        while (I > 0)
        {
            Console.WriteLine("Introduce un número:");
            A = Convert.ToInt32(Console.ReadLine()); 
            S = S + A;
            I = I - 1;
        }
        Console.WriteLine("La sumatoria de los números ingresados es: " + S);
    }
}