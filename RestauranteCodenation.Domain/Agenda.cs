﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Domain
{
    public class Agenda
    {
        public long Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public List<AgendaCardapio> AgendaCardapios { get; set; }
    }
}
