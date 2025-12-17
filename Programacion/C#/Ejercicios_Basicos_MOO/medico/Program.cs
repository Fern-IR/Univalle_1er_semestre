using System.Security.Cryptography.X509Certificates;

internal class Program
{
    public class Paciente
    {
        public string id;
        public string nombre;
        public string historialmedico;
        public Paciente(string pId, string pNombre, string pHistorialmedico)
        {
            id = pId;
            nombre = pNombre;
            historialmedico = pHistorialmedico;
        }
    }
    public class Doctor
    {
        public string id;
        public string nombre;
        public string especialidad;
        public Doctor(string pId, string pNombre, string pEspecialidad)
        {
            id = pId;
            nombre = pNombre;
            especialidad = pEspecialidad;
        }
    }
    public class Cita
    {
        public string id;
        public string fecha;
        public string motivo;
        public Cita(string pId, string pFecha, string pMotivo)
        {
            id = pId;
            fecha = pFecha;
            motivo = pMotivo;
        }
    }
    private static void Main(string[] args)
    {
        Paciente paciente1 = new Paciente("100","Fernando Illanes", "historial clinico");
        


        Cita cita1 = new Cita("PLN520", "10/05/2023", "dolor rodilla");
        Cita cita2 = new Cita("CPSC385", "23/12/2024", "Malestar");
        Cita cita3 = new Cita("NHP456", "27/09/2025", "rotura de brazo ");


        Doctor doctor1 = new Doctor("HTC", "Dr. Fernando illanes", "cirujano");

        Console.WriteLine(paciente1.nombre);
        Console.WriteLine("historial medico");
        Console.WriteLine(cita1.motivo);
        Console.WriteLine(cita1.fecha);
        Console.WriteLine(doctor1.nombre);
        Console.WriteLine(cita2.motivo);
        Console.WriteLine(cita2.fecha);
        Console.WriteLine(doctor1.nombre);
    }
}