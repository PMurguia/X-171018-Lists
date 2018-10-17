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


                if (numero.Contains("-"))
                {
                    break;
                }
                else if (numero.Contains(","))
                {
                    try
                    {
                    numDecimal = Convert.ToDouble(numero);
                    decim.Add(numDecimal);
                    contDecimal++;
                    break;

                    }
                    catch (FormatException ex)
                    {
                        ex.ToString();
                        Console.WriteLine("llama al equipo A. ");
                    }


                }
                else if (numero.Contains("."))
                {
                    try
                    {
                        numDecimal = Convert.ToDouble(numero);
                        numDecimal = numDecimal / 10;
                        decim.Add(numDecimal);
                        contDecimal++;
                        break;
                    }
                    catch(FormatException ex)
                    {
                        ex.ToString();
                        Console.WriteLine("LLama al equipo A.");
                    }
                }
                else
                {
                    try
                    {
                    numEntero = Convert.ToInt32(numero);
                    entero.Add(numEntero);
                    contEntero++;
                    }
                    catch (FormatException ex)
                    {
                        ex.ToString();
                        Console.WriteLine("Llama al equipo A. ");
                    }

                }

            } while (!numero.Contains("-"));

            if (numero.Contains("-"))
            {
                Console.WriteLine("Se han introducido un total de " + contDecimal + " números decimales. ");
                Console.WriteLine("Se han introducido un total de " + contEntero + " números enteros. ");

            }

            int suma = 0;
            foreach (int x in entero)
            {
                suma += x;
            }
            Console.WriteLine("La suma de los números enteros es: " + suma);

            double sumaEnt = 0;
            foreach (int x in entero)
            {
                Convert.ToDouble(x);
                sumaEnt += x;

            }

            double sumaDecim = 0;
            foreach (double x in decim)
            {
                sumaDecim += x;
            }
            Console.WriteLine("La media de todos los números introducidos es: " + (sumaEnt + sumaDecim) / (contDecimal + contEntero));

            Console.ReadLine();
        }
    }
}
