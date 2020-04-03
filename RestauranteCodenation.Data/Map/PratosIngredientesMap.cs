using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestauranteCodenation.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Data.Map
{
    public class PratosIngredientesMap : IEntityTypeConfiguration<PratosIngredientes>
    {
        public void Configure(EntityTypeBuilder<PratosIngredientes> builder)
        {
            builder.ToTable("PratosIngredientes");
            builder.HasKey(t => new { t.Ingrediente, t.IdPrato });

            builder.HasOne(i => i.Ingrediente)
                .WithMany(pi => pi.PratosIngredientes)
                .HasForeignKey(i => i.IdIngrediente);

            builder.HasOne(p => p.Prato)
                .WithMany(pi => pi.PratosIngredientes)
                .HasForeignKey(p => p.IdPrato);
        }
    }
}
