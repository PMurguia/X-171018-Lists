using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cantante> cantantesFamosos = new List<Cantante>()
            {
                new Cantante("Austin Powers", "Mojo"),
                new Cantante("Héctor Martínez", "Jolene")
            };

            foreach (Cantante x in cantantesFamosos)
            {
                Console.WriteLine(x.GetNombre());
                Console.WriteLine(x.GetDiscoMasVendido());
                Console.WriteLine();
            }

            Console.WriteLine("Dime un cantante famoso, ");
            string artista = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ahora su disco más vendido. ");
            string disco = Console.ReadLine();
            Console.WriteLine();
            Cantante c3 = new Cantante();
            c3.SetNombre(artista);
            c3.SetDiscoMasVendido(disco);
            cantantesFamosos.Add(c3);

            foreach (Cantante x in cantantesFamosos)
            {
                Console.WriteLine(x.GetNombre());
                Console.WriteLine(x.GetDiscoMasVendido());
                Console.WriteLine();
            }
            Console.ReadLine();
            int option = 0;
            int suma = 3;
            do
            {
                Console.WriteLine("¿Qué quieres hacer?\n1. Introducir otro artista y disco\n2. Salir del programa.");
                option = Int32.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:

                        Console.WriteLine("Dime un cantante famoso, ");
                        artista = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Ahora su disco más vendido. ");
                        disco = Console.ReadLine();
                        Console.WriteLine();
                        cantantesFamosos.Add(new Cantante(artista, disco));

                        foreach (Cantante x in cantantesFamosos)
                        {
                            Console.WriteLine(x.GetNombre());
                            Console.WriteLine(x.GetDiscoMasVendido());
                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        break;
                }
            } while (option != 2);
        }
    }
}
