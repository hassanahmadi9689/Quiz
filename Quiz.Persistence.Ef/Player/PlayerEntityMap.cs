using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Quiz.Persistence.Ef.Player;

public class PlayerEntityMap : IEntityTypeConfiguration<Entities.Player>
{
    public void Configure(EntityTypeBuilder<Entities.Player> builder)
    {
        builder.HasKey(_ => _.Id);
        builder.Property(_ => _.Id).ValueGeneratedOnAdd();
        builder.Property(_ => _.Name).IsRequired();
        builder.HasOne(_ => _.Team).WithMany(_ => _.Players);
    }
}