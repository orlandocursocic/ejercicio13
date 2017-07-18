using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    public class RecetaService : IRecetaService
    {
        private IRecetaRepository recetaRepository;

        public RecetaService(IRecetaRepository recetaRepository)
        {
            this.recetaRepository = recetaRepository;
        }

        public Receta Create(Receta receta)
        {
            receta.peso *= 2;

            return recetaRepository.Create(receta);
        }
    }
}
