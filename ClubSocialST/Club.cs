using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSocialST
{
    class Club
    {
        private Socio socioUno;
        private Socio socioDos;
        private Socio socioTres;

        public Socio retornaSocioUno(string nam,int num)
        {
            socioUno = new Socio(nam, num);
            return socioUno;
        }
        public Socio retornaSocioDos(string nam, int num)
        {
            socioDos = new Socio(nam, num);
            return socioDos;
        }
        public Socio retornaSocioTres(string nam, int num)
        {
            socioTres = new Socio(nam, num);
            return socioTres;
        }

        public void deAcaSaleElMasAntiguoDelClub()
        {
            if(socioUno.Antiguedad() > socioDos.Antiguedad())
            {
                if(socioUno.Antiguedad() > socioTres.Antiguedad())
                {
                    socioUno.imprimir();
                }
            }
            if (socioDos.Antiguedad() > socioTres.Antiguedad())
            {
                if (socioDos.Antiguedad() > socioUno.Antiguedad())
                {
                    socioDos.imprimir();
                }
            }
            if (socioTres.Antiguedad() > socioUno.Antiguedad())
            {
                if (socioTres.Antiguedad() > socioDos.Antiguedad())
                {
                    socioTres.imprimir();
                }
            }
        }

        public void allSocios()
        {
            Console.WriteLine("=>" + socioUno.Nombre() + "--" + socioUno.Antiguedad());
            Console.WriteLine("=>" + socioDos.Nombre() + "--" + socioDos.Antiguedad());
            Console.WriteLine("=>" + socioTres.Nombre() + "--" + socioTres.Antiguedad());
        }
    }
}
