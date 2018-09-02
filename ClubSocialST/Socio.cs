using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSocialST
{
    class Socio
    {
        private string nombre;
        private int antiguedad;

        public Socio()
        {

        }

        public Socio(string nombre, int antiguedad)
        {
            this.nombre = nombre;
            this.antiguedad = antiguedad;
        }
    
        public int Antiguedad()
        {
            return this.antiguedad;
        }

        public string Nombre()
        {
            return this.nombre;
        }
        
        public void imprimir()
        {
            Console.WriteLine("El socio "+nombre+" tiene "+antiguedad+" años en el club.");
        }

    }
}
