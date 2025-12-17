internal class Program
{
    private static void Main(string[] args)
    {
        {
        Console.WriteLine("¿Que dia de la semana fue el día 1 de este mes? (1-7)");
        int primerDia = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("¿Que dia del mes es hoy? ");
        int diaActual = Convert.ToInt32(Console.ReadLine());
        
        if(primerDia < 1 || primerDia > 7 || diaActual < 1 || diaActual > 31)
        {
            Console.WriteLine("Datos invalidos");
            return;
        }
        
        int diferencia = diaActual - 1;
        int diaSemana = (primerDia + diferencia) % 7;
        if(diaSemana == 0) diaSemana = 7;
        
        string[] dias = {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"};
        Console.WriteLine($"Hoy es {dias[diaSemana-1]}");
        }   
    }
}