internal class Program
{
    public class Usuario
    {
        public string id;
        public string nombre;
        public string email;
        public Usuario(string pId, string pNombre, string pEmail){
            id = pId;
            nombre = pNombre;
            email = pEmail;
        }
    }
    public class Publicacion
    {
        public string id;
        public string contenido;
        public string fecha;
        public Publicacion(string pId, string pContenido, DateTime pFecha){
            id = pId;
            contenido = pContenido;
            fecha = pFecha;
        }
    }
    public class Comentario
    {
        public string id;
        public string texto;
        public string fecha;
        public Comentario(string pId, string pTexto, DateTime pFecha)
        {
            id = pId;
            texto = pTexto;
            fecha = pFecha;
        }
    }
    private static void Main(string[] args)
    {
        Publicacion publicacion1 = new Publicacion("43532", "De Viaje", "15/05/2025");

        Comentario comentario1 = new Comentario("85686", "Me Gusta", "20/05/2025");

        Console.WriteLine(publicacion1.contenido);
        Console.WriteLine(comentario1.texto);
    }
}