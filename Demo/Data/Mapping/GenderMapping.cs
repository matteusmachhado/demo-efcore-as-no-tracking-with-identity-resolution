using Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Data.Mapping
{
    public class GenderMapping : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder
                .ToTable("tb_gender");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("id_gender");

            builder
                .Property(p => p.Name)
                .HasColumnName("nom_name")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .HasMany(p => p.Books)
                .WithOne(p => p.Gender)
                .HasForeignKey(p => p.GenderId);
        }
    }
}
