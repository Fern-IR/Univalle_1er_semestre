internal class Program
{
    private static void Main(string[] args)
    {
           double suma = 0;
        int n = 0;
        double numero;
        
        Console.WriteLine("Ingrese numeros positivos (Colocar un numero negativo para sacar el resultado):");
        
        do
        {
            Console.Write("Numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            
            if(numero >= 0)
            {
                suma += numero;
                n++;
            }
        }
        while(numero >= 0);
        
        if(n > 0)
        {
            double media = suma / n;
            Console.WriteLine("Media: " + media);
        }
        else
        {
            Console.WriteLine("No se ingresaron numeros validos");
        }
    }
}
