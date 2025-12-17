internal class Program
{
    public static double[,] sumaMatrices(double[,] pPeso1, double[,] pPeso2)
    {
        double[,] aux = new double[pPeso1.GetLength(0), pPeso1.GetLength(1)];

        if (pPeso1.GetLength(0) == pPeso2.GetLength(0) && pPeso1.GetLength(1) == pPeso2.GetLength(1))
        {
            for (int fila = 0; fila < pPeso1.GetLength(0); fila++)
                for (int columna = 0; columna < pPeso1.GetLength(1); columna++)
                    aux[fila, columna] = pPeso1[fila, columna] + pPeso2[fila, columna];
        }
        else
        {
            Console.WriteLine("es incompatible");
        }

        return aux;
    }

    private static void Main(string[] args)
    {
        double[,] pesoModelo1 = { { 0.1, 0.2 }, { 0.3, 0.4 } };
        double[,] pesoModelo2 = { { 0.5, 0.6 }, { 0.7, 0.8 } };
        double[,] sumaModelo = sumaMatrices(pesoModelo1, pesoModelo2);

        for (int i = 0; i < sumaModelo.GetLength(0); i++)
        {
            for (int j = 0; j < sumaModelo.GetLength(1); j++)
            {
                Console.Write(sumaModelo[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}