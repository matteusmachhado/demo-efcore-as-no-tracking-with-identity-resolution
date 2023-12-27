using Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Data.Mapping
{
    public class BookMapping : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder
                .ToTable("tb_book");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("id_book");

            builder
                .Property(p => p.Name)
                .HasColumnName("nom_name")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(p => p.AuthorId)
                .HasColumnName("id_author")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder
                .Property(p => p.GenderId)
                .HasColumnName("id_gender")
                .HasColumnType("uniqueidentifier")
                .IsRequired();
        }
    }
}
