internal class Program
{
    private static void Main(string[] args)
    {
        {
        Console.Write("Ingrese un número del 1 al 7:");
        int dia = Convert.ToInt32(Console.ReadLine());
        
        if(dia == 1)
            Console.WriteLine("Lunes");
        else if(dia == 2)
            Console.WriteLine("Martes");
        else if(dia == 3)
            Console.WriteLine("Miercoles");
        else if(dia == 4)
            Console.WriteLine("Jueves");
        else if(dia == 5)
            Console.WriteLine("Viernes");
        else if(dia == 6)
            Console.WriteLine("Sabado");
        else if(dia == 7)
            Console.WriteLine("Domingo");
        else
            Console.WriteLine("Error: El número debe estar entre 1 y 7");
    }
    }
}