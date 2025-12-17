internal class Program
{
    public class Usuario{
        public int id;
        public string nombre;
        public string correo;
        public Usuario(int pId, string pNombre, string pCorreo){
           
            id=pId;

            nombre=pNombre;

            correo=pCorreo;
        }
    }
            public class Prestamo{
                public int idPrestamo;
                public DateTime fechaPrestamo;
                public DateTime fechaDevolucion;
                public Prestamo(int pIdPrestamo, DateTime pFechaPrestamo, DateTime pFechaDevolucion){
                    
                    idPrestamo=pIdPrestamo;

                    fechaPrestamo=pFechaPrestamo;

                    fechaDevolucion=pFechaDevolucion;
                }
            }
                public class Libro{
                    public string ISBN;

                    public string titulo;

                    public string autor;

                    Boolean disponible;
                    public Libro(string pISBN, string pTitulo, string pAutor, Boolean pDisponible){

                        ISBN=pISBN;

                        titulo=pTitulo;

                        autor=pAutor;

                        disponible=pDisponible;
                    }        
                }
        private static void Main(string[] args)
        {
            Libro libro1 = new Libro("973-4324324234","No me puedes lastimar","David Goinggs",true);
            Libro libro2 = new Libro("973-4832149832","El hombre mas rico de babionia","George Samuel",true);
            Libro libro3 = new Libro("973-4832149735","Tengo boca pero no puedo gritar","Harlan Ellison",true);
            Libro libro4 = new Libro("973-4292149832","Psicologia oscura","Steven Turner",false);

            Usuario usuario1 = new Usuario(12345,"Kevin Feranndo Illanes Rios","kevinfernandoillanesrios@gmail.com");

            Console.WriteLine("Bienbenido a la biblioteca de la Univalle");
            Console.WriteLine("Los libros disponibles son:");

            Console.WriteLine("Libro:");
            Console.WriteLine(libro1.titulo);
            Console.WriteLine("Autor:");
            Console.WriteLine(libro1.autor);
            Console.WriteLine("Libro:");
            Console.WriteLine(libro2.titulo);
            Console.WriteLine("Autor:");
            Console.WriteLine(libro2.autor);
            Console.WriteLine("Libro:");
            Console.WriteLine(libro3.titulo);
            Console.WriteLine("Autor:");
            Console.WriteLine(libro3.autor);
            Console.WriteLine("Libro:");
            Console.WriteLine(libro4.titulo);
            Console.WriteLine("Autor:");
            Console.WriteLine(libro4.autor);
        }
}