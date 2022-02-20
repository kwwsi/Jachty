using Jachty.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Jachty.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Jacht>
    {
        public void Configure(EntityTypeBuilder<Jacht> builder)
        {
            builder.Property(p => p.ImageName).HasColumnName("ImageName");
        }
    }
}
