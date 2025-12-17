internal class Program
{
    private static void Main(string[] args)
    {
       {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        
        Console.Write("Horas trabajadas: ");
        double horas = double.Parse(Console.ReadLine());
        
        Console.Write("Pago por hora: ");
        double pago = double.Parse(Console.ReadLine());

        double normal, extra;
        if(horas <= 35)
        {
            normal = horas * pago;
            extra = 0;
        }
        else
        {
            normal = 35 * pago;
            extra = (horas - 35) * pago * 1.5;
        }
        
        double bruto = normal + extra;
        double mensual = bruto * 4;
        double impuestos = 0;

        if(mensual > 2000)
        {
            double resto = mensual - 2000;
            
            if(resto <= 220)
                impuestos = resto * 0.20;
            else
                impuestos = (220 * 0.20) + ((resto - 220) * 0.30);
            
            impuestos = impuestos / 4; 
        }

        double neto = bruto - impuestos;

        Console.WriteLine("\nRESULTADOS:");
        Console.WriteLine("Bruto: " + bruto);
        Console.WriteLine("Impuestos: " + impuestos);
        Console.WriteLine("Neto: " + neto);
    }
    }
}