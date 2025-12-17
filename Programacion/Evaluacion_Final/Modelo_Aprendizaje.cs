using System;
using System.Linq;

internal class Program
{

    public class EscalaMiniMax
    {
        public double[] minimo;
        public double[] maximo;

        public double[,] Normalizar(double[,] pDato)
        {
            int numMuestras = pDato.GetLength(0);          // Numero de filas 
            int numCaracteristicas = pDato.GetLength(1);   // Numero de columnas 

            minimo = new double[numCaracteristicas];
            maximo = new double[numCaracteristicas];


            for (int j = 0; j < numCaracteristicas; j++)
            {
                minimo[j] = pDato[0, j];
                maximo[j] = pDato[0, j];

                for (int i = 1; i < numMuestras; i++)
                {
                    if (pDato[i, j] < minimo[j]) minimo[j] = pDato[i, j];
                    if (pDato[i, j] > maximo[j]) maximo[j] = pDato[i, j];
                }
            }

            for (int i = 0; i < numMuestras; i++)
                for (int j = 0; j < numCaracteristicas; j++)
                    pDato[i, j] = (pDato[i, j] - minimo[j]) / (maximo[j] - minimo[j]);

            return pDato;
        }

        // Normaliza una sola fila de datos (una persona)
        public double[] Normalizar(double[] pDato)
        {
            double[] resultado = new double[pDato.Length];
            for (int i = 0; i < pDato.Length; i++)
                resultado[i] = (pDato[i] - minimo[i]) / (maximo[i] - minimo[i]);

            return resultado;
        }
    }

    public class ModeloLineal
    {
        public double[] pesos; 
        public double bias;    

        public ModeloLineal(int pNumCaracteristica)
        {
            pesos = new double[pNumCaracteristica];
            for (int i = 0; i < pNumCaracteristica; i++)
                pesos[i] = 0.01;
            bias = 0;
        }

        // Funcion sigmoide: convierte una entrada en valor entre 0 y 1
        public double sigmoide(double z) => 1.0 / (1.0 + Math.Exp(-z));

        private double[] FowardPropagation(double[,] x, int m, int n)
        {
            double[] yHat = new double[m];

            for (int i = 0; i < m; i++)
            {
                double z = 0;
                for (int j = 0; j < n; j++)
                    z += x[i, j] * pesos[j];  // suma ponderada de entradas
                z += bias;                   // agregar bias
                yHat[i] = sigmoide(z);       // aplicar sigmoide
            }

            return yHat;
        }


        private double[] BackwardPropagation(double[,] x, double[] y, double[] yHat, int m, int n)
        {
            double[] grad = new double[n];
            for (int j = 0; j < n; j++)
            {
                double suma = 0;
                for (int i = 0; i < m; i++)
                    suma += x[i, j] * (yHat[i] - y[i]);  // error * entrada
                grad[j] = suma / m;
            }
            return grad;
        }

        // Ajustar los pesos 
        private void ActualizarPesos(double[] grad, double tasa, int n)
        {
            for (int i = 0; i < n; i++)
                pesos[i] -= tasa * grad[i]; 
        }


        public void Entrenar(double[,] x, double[] y, double tasa, int epochs)
        {
            int m = x.GetLength(0); // numero de ejemplos
            int n = x.GetLength(1); // numero de características

            for (int epoch = 0; epoch < epochs; epoch++)
            {
                var yHat = FowardPropagation(x, m, n);             
                var grad = BackwardPropagation(x, y, yHat, m, n);      
                var gradBias = yHat.Zip(y, (p, t) => p - t).Average();    

                ActualizarPesos(grad, tasa, n);                           
                bias -= tasa * gradBias;                                 

                if (epoch % 10 == 0) 
                {
                    double error = yHat.Zip(y, (p, t) => Math.Pow(p - t, 2)).Average();
                    Console.WriteLine($"Epoch {epoch} - Error: {error:F4}");
                }
            }
        }


        public double Predecir(double[] x)
        {
            double z = x.Zip(pesos, (xi, wi) => xi * wi).Sum() + bias;
            return sigmoide(z); // devuelve valor entre 0 y 1
        }
    }

    private static void Main(string[] args)
    {
        // Datos de entrenamiento
        // Columnas: Temperatura °C, Presión , Edad 
        double[,] datos = {
            { 36.5, 120, 25 },
            { 39.0, 140, 45 },
            { 37.0, 110, 22 },
            { 38.5, 135, 50 },
            { 36.8, 125, 30 },
            { 39.2, 150, 60 }
        };

        // Etiquetas correspondientes: 0 = Saludable, 1 = Enfermo
        double[] etiquetas = { 0, 1, 0, 1, 0, 1 };

        var escala = new EscalaMiniMax();
        var datosNormalizados = escala.Normalizar(datos); 

        var modelo = new ModeloLineal(datos.GetLength(1)); 
        modelo.Entrenar(datosNormalizados, etiquetas, tasa: 0.1, epochs: 5000); 

        // Entrada de usuario
        Console.Write("Temperatura corporal °C: ");
        double temp = double.Parse(Console.ReadLine());

        Console.Write("Presión arterial: ");
        double presion = double.Parse(Console.ReadLine());

        Console.Write("Edad: ");
        double edad = double.Parse(Console.ReadLine());

        // Preparar los datos
        double[] entrada = { temp, presion, edad };
        var entradaNormalizada = escala.Normalizar(entrada);

        // Hacer la prediccion
        double resultado = modelo.Predecir(entradaNormalizada);

        // Muestra el diagnostico
        Console.WriteLine(resultado > 0.5 ? "Diagnostico: Enfermo" : "Diagnostico: Saludable");
    }
}

