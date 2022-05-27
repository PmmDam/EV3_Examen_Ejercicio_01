using EV3_Examen_Ejercicio_01.Handlers;

namespace EV3_Examen_Ejercicio_01
{
    internal class Program
    {

        static string filePath = Path.Combine(Environment.CurrentDirectory, "Data", "Fichero.txt");
        public static async Task Main(string[] args)
        {
            // 1. Crea un método asíncrono que escriba en un fichero, por líneas, los números del 1 al 1000.
            // Haz que el método se ejecute en un camino de ejecución independiente paralelo(un thread del pool
            // de threads) y finaliza el programa, sin esperar a que la ejecución del método termine.

        
         _=  Task.Run(async () => await FileHandler.WriteTextAsync(filePath, 1000)).ConfigureAwait(false);

             
        }
    }
}