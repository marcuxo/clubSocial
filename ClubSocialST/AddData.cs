using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * @autor MarcoUrrutiaMolina
 */
namespace ClubSocialST
{
    class AddData
    {
        private string datoL;
        private int datoN;

        public AddData()
        {

        }

        public void tomaDeDatos()
        {
            Console.WriteLine("Ingresa el nombre del socio: ");
            datoL = Console.ReadLine();

            Console.WriteLine("Ingresa el ano : ");
            string datoNull = Console.ReadLine();
            datoN = Convert.ToInt16(datoNull);
            
        }

        public string acaEstaElNombre()
        {
            return this.datoL;
        }

        public int acaEstaElAnnio()
        {
            return this.datoN;
        }
    }
}
