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
    class Program
    {
        static void Main(string[] args)
        {

            AddData tomaDatos = new AddData();
            Club socio1 = new Club();

            tomaDatos.tomaDeDatos();
            socio1.retornaSocioUno(tomaDatos.acaEstaElNombre(), tomaDatos.acaEstaElAnnio());

            tomaDatos.tomaDeDatos();
            socio1.retornaSocioDos(tomaDatos.acaEstaElNombre(), tomaDatos.acaEstaElAnnio());

            tomaDatos.tomaDeDatos();
            socio1.retornaSocioTres(tomaDatos.acaEstaElNombre(), tomaDatos.acaEstaElAnnio());

            socio1.deAcaSaleElMasAntiguoDelClub();
            socio1.allSocios();
        }
    }
}
