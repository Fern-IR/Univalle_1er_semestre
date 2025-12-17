internal class Program
{
    private static void Main(string[] args)
    {
        int limite = 10;
        float[] Estaturas = new float[limite];
        int cantidad, indice;
        Console.WriteLine("Introducir la cantidad de estudiantes");
        cantidad = Convert.ToInt16(Console.ReadLine());
        indice = 0;
        float valor;
        while (indice < cantidad)
        {
            Console.WriteLine("Introducir la estatura del estudiante:");
            valor = Convert.ToSingle(Console.ReadLine());
            Estaturas[indice] = valor;
            indice = indice + 1;
        }
        indice = 0;
        while (indice < cantidad)
        {
            Console.WriteLine(Estaturas[indice]);
            indice = indice + 1;
        }
        indice = 0;
        float suma = 0;
        while (indice < cantidad)
        {
            suma = suma + Estaturas[indice];
            indice = indice + 1;
        }
        
        float promedio = suma / cantidad;

        int cuentaAltos = 0;
        int cuentaBajos = 0;
        indice = 0;

        while (indice < cantidad)
        {
            if (Estaturas[indice] >= promedio)
            {
                cuentaAltos = cuentaAltos + 1;
            }
            else
            {
                cuentaBajos = cuentaBajos + 1;
            }
            indice = indice + 1;
        }

        Console.WriteLine("La sumatoria de estaturas es:" + suma);
        Console.WriteLine("El promedio de estaturas es:" + promedio);
        Console.WriteLine("Cantidad de estudiantes altos:" + cuentaAltos);
        Console.WriteLine("Cantidad de estudiantes bajos:" + cuentaBajos);
    }
}

