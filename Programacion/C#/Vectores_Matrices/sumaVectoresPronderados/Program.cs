internal class Program
{
    public static double[] sumaPonderada(double[] vector1, double[] vector2, double peso1, double peso2)
    {
        double[] resultado = new double[vector1.Length];
        
        if (vector1.Length == vector2.Length)
        {
            for (int i = 0; i < vector1.Length; i++)
            {
                resultado[i] = (vector1[i] * peso1) + (vector2[i] * peso2);
            }
        }
        else
        {
            Console.WriteLine("Vectores incompatibles");
        }

        return resultado;
    }

    private static void Main(string[] args)
    {
        double[] vectorA = { 1.0, 2.0, 3.0 };
        double[] vectorB = { 4.0, 5.0, 6.0 };
        double pesoA = 0.4;
        double pesoB = 0.6;

        double[] resultado = sumaPonderada(vectorA, vectorB, pesoA, pesoB);
        Console.WriteLine("Resultado suma ponderada: ");
        Console.WriteLine(string.Join(" - ", resultado));
    }
}
