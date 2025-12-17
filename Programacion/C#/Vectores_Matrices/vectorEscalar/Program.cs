internal class Program
{
    public static double[] sumaBroadcast(double[] vector, double escalar)
    {
        double[] resultado = new double[vector.Length];

        for (int i = 0; i < vector.Length; i++)
        {
            resultado[i] = vector[i] + escalar;
        }

        return resultado;
    }

    private static void Main(string[] args)
    {
        double[] vectorA = { 10.0, 20.0, 30.0 };
        double escalar = 5.0;

        double[] resultado = sumaBroadcast(vectorA, escalar);

        Console.WriteLine("Resultado de suma con broadcasting:");
        Console.WriteLine(string.Join(" - ", resultado));
    }
}
