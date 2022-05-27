using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EV3_Examen_Ejercicio_01.Handlers
{
    public static class FileHandler
    {

        // 1. Crea un método asíncrono que escriba en un fichero, por líneas, los números del 1 al 1000.
        // Haz que el método se ejecute en un camino de ejecución independiente paralelo(un thread del pool
        // de threads) y finaliza el programa, sin esperar a que la ejecución del método termine.

        public static async Task WriteTextAsync(string filePath,int limit)
        {
            int i = 0;
            string[] contents = new string[limit+1];
            
            while (i <= limit)
            {
                contents[i] = i.ToString();   
                i++;
            }
            await File.WriteAllLinesAsync(filePath,contents);
        }



    }
}
