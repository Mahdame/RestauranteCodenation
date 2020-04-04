using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Domain
{
    public class AgendaCardapio
    {
        public long IdCardapio { get; set; }
        public Cardapio Cardapio { get; set; }

        public long IdAgenda { get; set; }
        public Agenda Agenda { get; set; }
    }
}
