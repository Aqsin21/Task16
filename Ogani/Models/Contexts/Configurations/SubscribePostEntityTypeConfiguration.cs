using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Ogani.Models.Entities;


namespace Ogani.Models.Contexts.Configurations
{
   


    public class SubscribePostEntityTypeConfiguration: IEntityTypeConfiguration<SubscribePost>
    {
        public void Configure(EntityTypeBuilder<SubscribePost> builder)
        {
            builder.Property(m => m.Email).HasColumnType("varchar").HasMaxLength(100);
            builder.Property(m => m.CreatedAt).HasColumnType("datetime").IsRequired();
            builder.Property(m => m.ApprovedAt).HasColumnType("datetime");


            builder.HasKey(m => m.Email);
        }
    }

















        }
    

