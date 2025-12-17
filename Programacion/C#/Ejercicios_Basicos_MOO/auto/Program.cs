internal class Program
{
    public class cliente{
        public string Id;
        public string Nombre;
        public string Direccion;
    public cliente(string pId, string pNombre, string pDireccion) {
      Id = pId;
      Nombre = pNombre;
      Direccion = pDireccion;
    }
    }
  public class Ventas{
    public string IdVentas;
    public string Fecha;
    public float  Monto;
    public Ventas(string pIdVentas, string pFecha, float pMonto){
    
      IdVentas = pIdVentas;
      Fecha = pFecha;
      Monto = pMonto;
    }


    }

  public class Auto{
  public string modelo;
  public string Marca;
  public float Precio;
  public boleean Vendido;
    public Auto(string pModelo, string pMarca, float pPrecio, boleean pVendido){
    
      Modelo = pModelo;
      Marca = pMarca;
      Precio = pPrecio;
      Vendido = pVendido;
    }
  
  }



    private static void Main(string[] args)
    {
        Cliente cliente1 = new Cliente("432", "Kevin Illanes", "Cambodromo 6to anillo");

        
        Venta venta1 = new Venta("V001", "2025-05-16", 18500.75f);

        
        Auto auto1 = new Auto("R8", "Audi", 25,230, true);

        
        Console.WriteLine("= Información del Cliente =");
        Console.WriteLine("ID: " + cliente1.Id);
        Console.WriteLine("Nombre: " + cliente1.Nombre);
        Console.WriteLine("Dirección: " + cliente1.Direccion);

        Console.WriteLine("= Información de la Venta =");
        Console.WriteLine("ID Venta: " + venta1.IdVenta);
        Console.WriteLine("Fecha: " + venta1.Fecha);
        Console.WriteLine("Monto: " + venta1.Monto);

        Console.WriteLine("== Información del Auto =");
        Console.WriteLine("Marca: " + auto1.Marca);
        Console.WriteLine("Modelo: " + auto1.Modelo);
        Console.WriteLine("Precio: " + auto1.Precio);
        Console.WriteLine("Vendido: " + (auto1.Vendido ? "Sí" : "No"));

    }
}