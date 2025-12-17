using System.Data.Common;

internal class Program
{
    public class Mesero{
        public String Id;
        public String Nombre;
        public Mesero( String pId, String pNombre){
            Id=pId;
            Nombre=pNombre;
        }
        
    }
    public class Pedido{
        public string IdPedido;
        public string Estado;
        public float Total;
        public  Pedido(string pIdPedido, string pEstado, float pTotal){
            IdPedido=pIdPedido;
            Estado=pEstado;
            Total=pTotal;
        }
    }
    public class Menu{
        string IdMenu;
        string NombreMenu;
        float precioMenu;
        public Menu(string pIdMenu, string pNombreMenu,float precioMenu){
            IdMenu=pIdMenu;
            NombreMenu=pNombreMenu;
            precioMenu=precioMenu;
        }
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("----------MENÚ DEL DÍA----------");
        Console.WriteLine("1. papa con huevo - Bs 8.00");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("2. costillas - Bs 30.50");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("3. silpancho - Bs 25.00");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("4. locro - Bs 12.50");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Elija la una opcion");

        
    }
}
