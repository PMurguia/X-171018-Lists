using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elene_de_Troya
{
    class Griego
    {
        private string nombre;
        private int edad;
        private int fuerza;
        bool cFuerza;
        bool cEdad;
        private bool herido = false;
        private bool muerto = false;

        public Griego()
        {

        }
        public Griego(string nombre, int edad, int fuerza, bool herido, bool muerto)
        {
            if (ComprobarFuerza(fuerza) && ComprobarEdad(edad))
            {
                this.nombre = nombre;
                this.edad = edad;
                this.fuerza = fuerza;
                this.herido = herido;
                this.muerto = muerto;
            }
            else
            {
                this.nombre = nombre;
                this.edad = 25;
                this.fuerza = 5;
                this.herido = herido;
                this.muerto = muerto;
            }

        }
        public string GetNombre()
        {
            return nombre;
        }
        public int GetEdad()
        {
            return edad;
        }
        public int GetFuerza()
        {
            return fuerza;
        }
        public bool GetHerido()
        {
            return false;
        }
        public bool GetMuerto()
        {
            return false;
        }

        public void SetNombre(string nombre)
        {

            this.nombre = nombre;
        }
        public void SetEdad(int edad)
        {
            if (ComprobarEdad(edad))
            {
                this.edad = edad;
            }
            else
            {
                this.edad = 18;
            }

        }
        public void SetFuerza(int fuerza)
        {
            if (ComprobarFuerza(fuerza))
            {
                this.fuerza = fuerza;
            }
            else
            {
                this.fuerza = 5;
            }

        }
        public void SetHerido(bool herido)
        {
            this.herido = true;
        }
        public void SetMuerto(bool muerto)
        {
            this.muerto = true;
        }

        public bool Retirarse(bool retirarse)
        {
            return true;
        }

        public bool ComprobarEdad(int edad)
        {
            if (edad >= 15 && edad <= 60)
            {
                cEdad = true;
            }
            return cEdad;
        }

        public bool ComprobarFuerza(int fuerza)
        {
            if (fuerza >= 1 && fuerza <= 10)
            {
                cFuerza = true;
            }
            return cFuerza;
        }

        public bool Herido(bool herido)
        {
            if (herido == true)
            {
                Console.WriteLine("RETIRADA");
                return herido;
            }
            else
            {
                return herido;
            }
        }

        public bool Muerto(bool muerto)
        {
            if (muerto == true)
            {
                Console.Write("DÉJALE DESCANSAR, ESTÁ MUERTO.");
                return muerto;
            }
            else
            {
                return muerto;
            }

        }

        public void MostrarDatos()
        {

            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Fuerza: " + fuerza);
            Console.Write("Retirarse: ");
            Herido(this.herido);
            Muerto(this.muerto);

        }
    }
}
