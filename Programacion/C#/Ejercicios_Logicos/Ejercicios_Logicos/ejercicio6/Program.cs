internal class Program
{
    private static void Main(string[] args)
    {
        int X,S;
        X=1;
        S=0;
            while (X<=50)
            {
                S=S+X;
                X=X+1;
            }
            Console.Write("Resultado:"+S);
    }
}