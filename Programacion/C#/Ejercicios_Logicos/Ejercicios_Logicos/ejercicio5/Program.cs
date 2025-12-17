internal class Program
{
    private static void Main(string[] args)
    {
        int A,B,C;
        Console.WriteLine("Introducir el valor A:");
        A=Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Introducir el valor B:");
        B=Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Introducir el valor C:");
        C=Convert.ToInt16(Console.ReadLine());
        if (A>B && A>C)
        {
            Console.WriteLine("El mayor es:"+A);
        }
        else
        {
            if (B>A && B>C)
            {
                Console.WriteLine("El mayor es:"+B);
            }
            else
            {
                 Console.WriteLine("El mayor es:"+C); 
            }
        }
    }
}