﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_InyecciónDeDependencias
{
    class Escopeta : IArma
    {
        public string Disparar()
        {
            return "pum PUMMMM !! ..";
        }
    }
}
