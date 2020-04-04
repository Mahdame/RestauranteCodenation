using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Domain
{
    public class Prato
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public List<PratosIngredientes> PratosIngredientes { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public long IdTipoPrato { get; set; }
        public TipoPrato tipoPrato { get; set; }
    }
}
