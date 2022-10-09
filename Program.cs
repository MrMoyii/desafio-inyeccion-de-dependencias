using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_InyecciónDeDependencias
{
    class Program
    {
        static void Main(string[] args)
        {
            //disparar Escopeta.
            var soladoES = new Soldado();
            soladoES.setArma(new Escopeta());
            Console.WriteLine(soladoES.Disparar());

            //disparar Revolver.
            Soldado soldado = new Soldado();
            soldado.setArma(new Revolver());
            Console.WriteLine(soldado.Disparar());

            //disparar Rifle
            soldado.setArma(new Rifle());
            Console.WriteLine(soldado.Disparar());

        }
    }
}
