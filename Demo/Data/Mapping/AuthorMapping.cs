using Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Mapping
{
    public class AuthorMapping : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder
                .ToTable("tb_author");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("id_author");

            builder
                .Property(x => x.Name)
                .HasColumnName("nom_name")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .HasMany(p => p.Books)
                .WithOne(p => p.Author)
                .HasForeignKey(p => p.AuthorId);
        }
    }
}
