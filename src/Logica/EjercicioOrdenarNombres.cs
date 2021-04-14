using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EjercicioOrdenarNombres
    {
        static readonly int cantNombres = 5;

        public static void Ejecutar()
        {
            List<string> nombres = new List<string>();

            for (int i = 0; i < cantNombres; i++)
            {
                Console.WriteLine($"Ingrese Nombre {i+1}: ");
                string nombre = Console.ReadLine();
                nombres.Add(nombre);
            }
            nombres.Sort();

            Console.WriteLine();
            Console.WriteLine("La lista de nombres ordenada es:");
            for (int i = 0; i < nombres.Count; i++)
            {
                Console.WriteLine(nombres[i]);
            }
        }
    }
}
