using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Domain
{
    public class PratosIngredientes
    {
        public long IdPrato { get; set; }
        public Prato Prato { get; set; }

        public long IdIngrediente { get; set; }
        public Ingrediente Ingrediente { get; set; }
    }
}