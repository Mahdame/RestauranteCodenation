﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestauranteCodenation.Domain;

namespace RestauranteCodenation.Data.Map
{
    public class PratosIngredientesMap : IEntityTypeConfiguration<PratosIngredientes>
    {
        public void Configure(EntityTypeBuilder<PratosIngredientes> eb)
        {
            eb.ToTable("PratosIngredientes");
            eb.HasKey(x => new { x.IdIngrediente, x.IdPrato });

            eb.HasOne(x => x.Ingrediente)
              .WithMany(x => x.PratosIngredientes)
              .HasForeignKey(x => x.IdIngrediente);

            eb.HasOne(x => x.Prato)
              .WithMany(x => x.PratosIngredientes)
              .HasForeignKey(x => x.IdPrato);

            eb.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
