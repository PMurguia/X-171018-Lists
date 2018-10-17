using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> entero = new List<int>();
            List<double> decim = new List<double>();

            string numero = "";
            int contDecimal = 0;
            int contEntero = 0;
            double numDecimal = 0;
            int numEntero = 0;

            do
            {

                Console.WriteLine("Introduce un número, decimal o entero. ");
                numero = Console.ReadLine();

                if (numero.Contains(","))
                {
                    numDecimal = Convert.ToDouble(numero);
                    decim.Add(numDecimal);
                    contDecimal++;

                }
                else if (numero.Contains("."))
                {
                    numDecimal = Convert.ToDouble(numero);
                    numDecimal = numDecimal / 10;
                    decim.Add(numDecimal);
                    contDecimal++;

                }
                else if (numero.Contains("-"))
                {
                    break;
                }
                else
                {
                    numEntero = Convert.ToInt32(numero);
                    entero.Add(numEntero);
                    contEntero++;

                }

            } while (!numero.Contains("-"));

            if (numero.Contains("-"))
            {
                Console.WriteLine("Se han introducido un total de " + contDecimal + " números decimales. ");
                Console.WriteLine("Se han introducido un total de " + contEntero + " números enteros. ");

            }

            int suma = 0;
            foreach(int x in entero)
            {
                suma += x;
            }
            Console.WriteLine("La suma de los números enteros es: " +suma);

            double sumaEnt = 0;
            foreach(int x in entero)
            {
                Convert.ToDouble(x);
                sumaEnt += x;

            }

            double sumaDecim = 0;
            foreach(double x in decim)
            {
                sumaDecim += x;
            }
            Console.WriteLine("La media de todos los números introducidos es: " +(sumaEnt + sumaDecim) / (contDecimal + contEntero));
            
            Console.ReadLine();
        }
    }
}
