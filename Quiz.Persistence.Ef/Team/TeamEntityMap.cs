using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Quiz.Persistence.Ef.Team;

public class TeamEntityMap : IEntityTypeConfiguration<Entities.Team>
{
    public void Configure(EntityTypeBuilder<Entities.Team> builder)
    {
        builder.HasKey(_ => _.Id);
        builder.Property(_ => _.Id).ValueGeneratedOnAdd();
        builder.Property(_ => _.Name).IsRequired();
        builder.Property(_ => _.FirstColor).IsRequired();
        builder.Property(_ => _.SecondColor).IsRequired();
        builder.HasMany(_ => _.Players).WithOne(_ => _.Team);
    }
}