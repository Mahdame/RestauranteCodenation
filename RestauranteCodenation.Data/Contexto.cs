using Microsoft.EntityFrameworkCore;
using RestauranteCodenation.Data.Map;
using RestauranteCodenation.Domain;
using System;

namespace RestauranteCodenation.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Cardapio> Cardapio { get; set; }
        public DbSet<Ingrediente> Ingrediente { get; set; }
        public DbSet<Prato> Prato { get; set; }
        public DbSet<TipoPrato> TipoPrato { get; set; }
        public DbSet<Agenda> DiaCardapio { get; set; }
        public DbSet<PratosIngredientes> PratosIngredientes { get; set; }
        public DbSet<AgendaCardapio> AgendaCardapio { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=MAH-DELL\SQLEXPRESS;database=RestauranteDaEsquina;trusted_connection=true;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.ApplyConfiguration(new IngredienteMap());
            mb.ApplyConfiguration(new PratoMap());
            mb.ApplyConfiguration(new PratosIngredientesMap());
            mb.ApplyConfiguration(new TipoPratoMap());
            mb.ApplyConfiguration(new AgendaCardapioMap());
            mb.ApplyConfiguration(new AgendaMap());
            mb.ApplyConfiguration(new CardapioMap());

            base.OnModelCreating(mb);
        }
    }
};
