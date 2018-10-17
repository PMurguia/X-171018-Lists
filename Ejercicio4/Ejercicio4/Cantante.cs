using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Cantante
    {
        private string nombre;
        private string discoMasVendido;

        public Cantante()
        {

        }

        public Cantante(string nombre, string discoMasVendido)
        {
            this.nombre = nombre;
            this.discoMasVendido = discoMasVendido;
        }

        public string GetNombre()
        {
            return nombre;
        }
        public string GetDiscoMasVendido()
        {
            return discoMasVendido;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetDiscoMasVendido(string discoMasVendido)
        {
            this.discoMasVendido = discoMasVendido;
        }

    }
}
