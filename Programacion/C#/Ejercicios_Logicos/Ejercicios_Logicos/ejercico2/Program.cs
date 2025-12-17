internal class Program
{
    private static void Main(string[] args)
    {
        int A,B,C;
        Console.Write("Introducir el valor A:");
        A=Convert.ToInt16(Console.ReadLine());
        Console.Write("Introducir el valor B:");
        B=Convert.ToInt16(Console.ReadLine());
        Console.Write("Introducir el valor C:");
        C=Convert.ToInt16(Console.ReadLine());

        Console.WriteLine(A + " " + B + " " + C);
        int Aux=A;
        A=C;
        C=B;
        B=Aux;

        Console.WriteLine(A + " " + B + " " + C);

    }
}