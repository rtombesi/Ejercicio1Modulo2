using System.Text.Json;
using EjercicioClase1Modulo2.Ejercicio1;
using EjercicioClase1Modulo2.Ejercicio2;
using EjercicioClase1Modulo2.Ejercicio3;

namespace EjercicioClase1Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio clase 1 modulo 2");
            // Consigna:
            // En la ruta principal del proyecto hay 3 archivos json, para cada uno de ellos crear las clases que consideren necesarias para poder deserializar correctamente
            // Uso: JsonSerializer.Deserialize<ClaseCreada>(data);

            var pathEjercicio1 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio1.json";
            var pathEjercicio2 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio2.json";
            var pathEjercicio3 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio3.json";

            //Resultado Ejercicio 1
            var dataEjercicio1 = File.ReadAllText(pathEjercicio1);
            var resultEjercicio1 = JsonSerializer.Deserialize<Aplicacion>(dataEjercicio1);
   

            //Resultado Ejercicio 2
            var dataEjercicio2 = File.ReadAllText(pathEjercicio2);
            var resultEjercicio2 = JsonSerializer.Deserialize<CentroEstadisticas>(dataEjercicio2);
         
            //Resultado Ejercicio 3
            var dataEjercicio3 = File.ReadAllText(pathEjercicio3);
            var resultEjercicio3 = JsonSerializer.Deserialize<Almacen>(dataEjercicio3);




        }
    }
}