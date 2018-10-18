using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elene_de_Troya
{
    class Caballo
    {
        private int capacidad;
        private int ocupacion;
        private List<Griego> Ocupantes=new List<Griego>();
        

        private Caballo()
        {
            this.capacidad = 20;
        }

        public int GetCapacidad()
        {
            return capacidad;
        }
        public int GetOcupacion()
        {
            return ocupacion;
        }
        
        public void SetOcupacion(int ocupacion)
        {
            this.ocupacion = ocupacion;
        }

        public int BuscarNombre(string nombre)
        {
            int cont = 0;
            foreach (Griego item in Ocupantes)
            {
                if (item.GetNombre() == nombre)
                {
                    return cont;
                }
                cont++;
            }
            return (-1);
        }

        public int MostrarGuerreroPosicion(int pos)
        {
            pos = pos - 1;
            try
            {
               Ocupantes.ElementAt(pos);
            }
            catch
            {
                Console.WriteLine("EEEEEEEEEERROR. ");
            }
            return pos;
        }

        //public void MontarseEnCaballo(Griego guerrero)
        //{
        //    Ocupantes.Add(guerrero);
        //    Console.WriteLine("Guerrero griego " + guerrero + " montado en caballo. ");
        //}


        //public string MostrarCaballo(int capacidad, int ocupacion, Griego guerrero)
        //{
            
        //}




    }
}
