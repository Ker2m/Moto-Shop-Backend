using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class EkipmanConfiguration : BaseConfiguration<Ekipman, int>
{
	public override void Configure(EntityTypeBuilder<Ekipman> builder)
	{
		base.Configure(builder); // Base configuration from the abstract class

		builder.Property(x => x.Marka).IsRequired();
		builder.Property(x => x.Fiyat).IsRequired();
		builder.Property(x => x.Özellikler).IsRequired();

	}
}
