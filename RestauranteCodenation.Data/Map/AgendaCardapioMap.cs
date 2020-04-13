using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestauranteCodenation.Domain;

namespace RestauranteCodenation.Data.Map
{
    public class AgendaCardapioMap : IEntityTypeConfiguration<AgendaCardapio>
    {
        public void Configure(EntityTypeBuilder<AgendaCardapio> eb)
        {
            eb.ToTable("AgendaCardapio");

            eb.HasKey(t => new { t.IdAgenda, t.IdCardapio });

            eb.HasOne(a => a.Agenda)
                .WithMany(ac => ac.AgendaCardapios)
                .HasForeignKey(p => p.IdAgenda);

            eb.HasOne(c => c.Cardapio)
                .WithMany(ac => ac.AgendaCardapio)
                .HasForeignKey(ac => ac.IdCardapio);

            eb.Property(x => x.Id)
                .UseIdentityColumn();

        }
    }
}
