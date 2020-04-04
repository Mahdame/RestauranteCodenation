using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Domain
{
    public class TipoPrato
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public List<Prato> Prato { get; set; }
    }
}
