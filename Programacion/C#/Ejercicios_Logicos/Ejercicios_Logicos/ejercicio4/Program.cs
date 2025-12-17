internal class Program
{
    private static void Main(string[] args)
    {
        int A, B;
        do
        {
            Console.Write("Introducir el valor de A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introducir el valor de B: ");
            B = Convert.ToInt32(Console.ReadLine());
            if (A == B)
            {
                Console.WriteLine("Los valores deben ser distintos. Inténtalo de nuevo.");
            }
        } while (A == B); 
        if (A > B)
        {
            Console.WriteLine("El número mayor es: " + A);
        }
        else
        {
            Console.WriteLine("El número mayor es: " + B);
        }
    }
}