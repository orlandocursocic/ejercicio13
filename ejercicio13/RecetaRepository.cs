﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    public class RecetaRepository : IRecetaRepository
    {
        public Receta Create(Receta receta)
        {
            return receta;
        }
    }
}
