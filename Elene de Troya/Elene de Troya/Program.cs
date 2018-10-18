using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elene_de_Troya
{
    class Program
    {
        static void Main(string[] args)
        {
            Troyano t1 = new Troyano();
            t1.SetNombre("Paris");
            t1.SetEdad(1);
            t1.SetFuerza(12);
            t1.SetHerido(true);
            t1.SetMuerto(false);

            Troyano t2 = new Troyano("TroyanoX", 18, 10, false, false);


            //Console.WriteLine("***********************Elene de Troya***********************\n");

            //Console.WriteLine("Alístate en el ejército Troyano. ¡Tu polis te necesita!");
            //Console.WriteLine("Nombre: ");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("Edad: ");
            //int edad = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Fuerza: ");
            //int fuerza = Int32.Parse(Console.ReadLine());

            t1.MostrarDatos();
            Console.WriteLine();
            t2.MostrarDatos();
            Console.WriteLine();


            Griego g1 = new Griego("GriegoX",20,4,false,true);
            g1.MostrarDatos();


            Console.ReadLine();
        }
    }
}
