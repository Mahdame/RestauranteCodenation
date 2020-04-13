using RestauranteCodenation.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace RestauranteCodenation.Data.Repositorio
{
    public class PratosIngredientesRepositorio : RepositorioBase<PratosIngredientes>
    {
        private readonly Contexto _contexto;

        public List<PratosIngredientes> SelecionarCompleto()
        {
            return _contexto
                .PratosIngredientes
                .Include(x => x.Ingrediente)
                .Include(x => x.Prato)
                .ToList();
        }
    }
}
