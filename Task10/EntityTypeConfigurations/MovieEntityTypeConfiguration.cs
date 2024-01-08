using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task10.Models;

namespace Task10.EntityTypeConfigurations;


    public class MovieEntityTypeConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(e => e.Id).HasName("Movie_PK");
            builder.Property(e => e.Id).UseIdentityColumn();

            builder.Property(e => e.Title).HasMaxLength(256).IsRequired();

            builder.Property(e => e.ReleaseDate).IsRequired();

            builder.Property(e => e.Genre).HasMaxLength(128).IsRequired();

            builder.Property(e => e.Price).IsRequired();
            
        }
    }
