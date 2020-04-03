using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestauranteCodenation.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Data.Map
{
    public class AgendaCardapioMap : IEntityTypeConfiguration<AgendaCardapio>
    {
        public void Configure(EntityTypeBuilder<AgendaCardapio> builder)
        {
            builder.ToTable("AgendaCardapio");

            builder.HasKey(t => new { t.IdAgenda, t.IdCardapio });

            builder.HasOne(a => a.Agenda)
                .WithMany(ac => ac.AgendaCardapios)
                .HasForeignKey(p => p.IdAgenda);

            builder.HasOne(c => c.Cardapio)
                .WithMany(ac => ac.AgendaCardapio)
                .HasForeignKey(ac => ac.IdCardapio);


        }
    }
}
