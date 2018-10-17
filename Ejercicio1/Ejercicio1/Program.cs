using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        public static void CreaLista(List <string> compra)
        {
            compra.Add("Manzanas");
            compra.Add("Peras");
            compra.Add("Leche");
            compra.Add("Cereales");
        }

        public static void MostrarLista(List<string> compra)
        {
            foreach (string x in compra)
            {
                Console.WriteLine(x);
            }
        }

        public static void OrdenarLista(List<string> compra)
        {
            compra.Sort();
            foreach (string x in compra)
            {
                Console.WriteLine(x);
            }
        }

        public static void BorrarDeLaLista(List<string> compra, string articulo)
        {
            compra.Remove(articulo);
        }

        public static int ContarElementos(List<string> compra)
        {
            
            return compra.Count;
        }
        static void Main(string[] args)
        {
            
            List<string> compra = new List<string>();
            CreaLista(compra);
            Console.WriteLine();
            MostrarLista(compra);
            Console.WriteLine();
            OrdenarLista(compra);
            Console.WriteLine();
            string articulo = "Manzanas";
            BorrarDeLaLista(compra,articulo);
            Console.WriteLine();
            Console.WriteLine(ContarElementos(compra));


            Console.ReadLine();
        }
    }
}
