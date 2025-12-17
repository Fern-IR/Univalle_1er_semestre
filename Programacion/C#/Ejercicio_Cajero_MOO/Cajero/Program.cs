using System.Runtime.CompilerServices;

internal class Program
{
    
    public class Tarjeta{
        public string numero;
        public string titular;
        public bool estaActiva;
        public string entidadEmisor;
        public decimal saldo;
        public int pIN;

        public bool EsValida(){
            if (estaActiva==true){
                return true;
            }
            else{
                return false;
            }
        }
        public Tarjeta(string pNumero, string pTitular, bool pEstaActiva,
                       string pEentidadEmisor, decimal pSaldo, int pPIN){
             numero=pNumero;
             titular=pTitular;
             estaActiva=pEstaActiva;
             entidadEmisor=pEentidadEmisor;
             saldo=pSaldo;
             pIN=pPIN;
        }
        public decimal ObtenerSaldo(){
            return saldo;
        }
    }
    public class Cajero{
        public string identificador;
        public string ubicacion;
        public decimal montoDisponible;
        public Tarjeta TarjetaActual;
        public Cajero(string pIdentificador, string pUbicacion,
                       decimal pMontoDisponible){
            identificador=pIdentificador;
            ubicacion=pUbicacion;
            montoDisponible=pMontoDisponible;
            TarjetaActual=null;
        }
        public void InsertarTarjeta(Tarjeta pTarjeta){
            if (pTarjeta.EsValida()==true){
                TarjetaActual=pTarjeta;
            }
            else{
                Console.WriteLine("Tarjeta Invalida o Bloqueada");
            }
        }
        public bool VerificarPIN(int pPIN){
            if(TarjetaActual!=null && TarjetaActual.pIN==pPIN){
                Console.WriteLine("Tarjeta Autorizada");
                return true;
            }
        
            else{
                Console.WriteLine("Tarjeta no Autorizada");
            return false;

            }
            
        }
        public decimal ConsultarSaldo(){
            return TarjetaActual.saldo;
        }
        public void RetirarDinero(int montoRetiro){
            if (montoDisponible>=montoRetiro)
                if(montoRetiro<=TarjetaActual.saldo)
                TarjetaActual.saldo=TarjetaActual.saldo-montoRetiro;
                else
                    Console.WriteLine("SALDO INSUFICIENTE");
            else
                Console.WriteLine("EL CAJERO NO CUENTA CON DINERO");
                
            
            
            
        }
    }
    private static void Main(string[] args)
    {
        Cajero cajero=new Cajero("Cajero001","Campus Univalle",19000);
        Cajero cajeroguardia=new Cajero("Cajero002","guardia",1000);
        Tarjeta tarjetaKevin=new Tarjeta("4799-3245-4567-9828","Kevin Fernando",false,"Banco Fie",2300,1234);
        int miPIN, opcion;
        decimal miSaldo;
       int montoRetiro;
       Console.WriteLine(tarjetaKevin.titular);
       tarjetaKevin.estaActiva=true;
       cajero.InsertarTarjeta(tarjetaKevin);
       if (cajero.TarjetaActual!=null){
        Console.Write("Introduzca su PIN:");
        miPIN=Convert.ToInt16(Console.ReadLine());
        if(cajero.VerificarPIN(miPIN)){
            do{
                Console.WriteLine("Bienvenido al Menu principal");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Retirar dinero");
                Console.WriteLine("0. salir");
                Console.WriteLine("Seleccione una opcion:");
                opcion=Convert.ToInt16(Console.ReadLine());
                switch (opcion){
                    case 1:
                        miSaldo=cajero.ConsultarSaldo();
                        Console.WriteLine("SALDO ACTUAL:"+miSaldo);
                        break;
                    case 2:
                        Console.Write("Introducir el monto a retirar:");
                        montoRetiro=Convert.ToInt16(Console.ReadLine());
                        cajero.RetirarDinero(montoRetiro);
                        break;

                }
            }while (opcion!=0);
        }
       }
      
    }
}