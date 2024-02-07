using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class MotorConfiguration : BaseConfiguration<Motor, int>
{
	public override void Configure(EntityTypeBuilder<Motor> builder)
	{
		base.Configure(builder); // Base configuration from the abstract class

		builder.Property(x => x.Marka).IsRequired();
		builder.Property(x => x.Model).IsRequired();
		builder.Property(x => x.Resim).IsRequired();
		builder.Property(x => x.Fiyat).IsRequired();
		builder.Property(x => x.Yil).IsRequired();
		builder.Property(x => x.Km).IsRequired();
		builder.Property(x => x.Renk).IsRequired();
		builder.Property(x => x.YakitTipi).IsRequired();
		builder.Property(x => x.Motor_Hacmi).IsRequired();
		builder.Property(x => x.Motor_Gucu).IsRequired();
		builder.Property(x => x.Vites).IsRequired();
		builder.Property(x => x.Durumu).IsRequired();

	}
}
