internal class Program
{
    private static void Main(string[] args)
    {
        string nombre;
        int horaTrabajo;
        float precioHora;
        Console.Write("Introducir nombre:");
        nombre=Console.ReadLine();
        Console.Write("Introducir horas trabajadas:");
        horaTrabajo=Convert.ToInt16(Console.ReadLine());
        Console.Write("Introducir precio por hora:");
        precioHora=Convert.ToSingle(Console.ReadLine());
        float salarioBruto=horaTrabajo*precioHora;
        float impuestoIva=salarioBruto*Convert.ToSingle(0.13);
        float salarioNeto=salarioBruto-impuestoIva;
        Console.WriteLine("Nombre del trabajador:"+nombre);
        Console.WriteLine("Salario Bruto:"+salarioBruto);
        Console.WriteLine("Salario Neto:"+salarioNeto);
    }
}