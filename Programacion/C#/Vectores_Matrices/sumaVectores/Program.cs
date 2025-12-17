internal class Program
{
    public static double[] sumaVectores (double[] pCapa1, double[] pGradiente)
    {
        double[] aux=new double[pCapa1.Length];
        if(pCapa1.Length == pGradiente.Length){
            for(int indice=0; indice<pCapa1.Length; indice++)
                aux[indice]=pCapa1[indice]+pGradiente[indice];
        }
        else
            Console.WriteLine("Vector Incompatible");
        return aux;
    }
    private static void Main(string[] args)
    {
        double[] capa1={1.0,2.0,3.0};
        double[] gradiente={0.001,0.002,0.003};
        double[]resultado=sumaVectores(capa1,gradiente);
        Console.WriteLine(string.Join("-",resultado));
    }
}