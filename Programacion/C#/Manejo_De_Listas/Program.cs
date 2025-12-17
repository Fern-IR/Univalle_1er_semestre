internal class Program
{   
    int limite=100;
    string[] colaCliente=new string[100];
    int cantidad = 0;
    public void agregarCliente(string pTicket) {
        colaCliente[cantidad]=pTicket;
        cantidad = cantidad + 1;
    }
    public void mostrarCola(){
        int Indice=0;
        while (Indice < cantidad){
            Console.WriteLine("turno en la cola:"+colaCliente[Indice]);
            Indice = Indice + 1;
        }
    }
    public void atenderCliente()
    {
        int indice = 0;
        if (cantidad > 0)
        {
            Console.WriteLine("cliente atendido con el" + colaCliente[indice]);
            while (indice < cantidad)
            {
                colaCliente[indice] = colaCliente[indice + 1];
                indice = indice - 1;
            }
            cantidad = cantidad - 1;

        }
        else
        {
            Console.WriteLine("Cola vacia");
        }
    }
    private static void Main(string[] args)
    {
        Program programa = new Program();
        programa.agregarCliente("ticket 1");
        programa.agregarCliente("ticket 2");
        programa.agregarCliente("ticket 3");
        programa.mostrarCola();
        programa.atenderCliente();
        programa.mostrarCola();
        programa.agregarCliente("ticket 4");
        programa.agregarCliente("ticket 5");
        programa.atenderCliente();
        programa.atenderCliente();
        programa.atenderCliente();
        programa.atenderCliente();
    }
}