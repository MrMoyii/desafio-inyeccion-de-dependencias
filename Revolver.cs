using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_InyecciónDeDependencias
{
    class Revolver : IArma
    {
        public string Disparar()
        {
            return "Pum Pum ..";
        }
    }
}
