using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_InyecciónDeDependencias
{
    class Soldado
    {
        protected IArma arma;

        public void setArma(IArma arma)
        {
            this.arma = arma;
        }

        public string Disparar()
        {
            return this.arma.Disparar();
        }
    }
}
