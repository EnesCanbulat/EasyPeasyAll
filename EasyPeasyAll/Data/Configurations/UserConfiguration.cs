using EasyPeasyAll.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyPeasyAll.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Tablo Adı
            builder.ToTable("Users");

            // Primary Key (Birincil Anahtar)
            builder.HasKey(u => u.Id);

            // Name Özelliği
            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(100);

            // EmailAddress Özelliği
            builder.Property(u => u.EmailAddress)
                .IsRequired()
                .HasMaxLength(255);

            // Unique Index (Benzersiz E-posta Kısıtlaması)
            builder.HasIndex(u => u.EmailAddress)
                .IsUnique();

            // İlişki Tanımı (Bir Kullanıcının Birden Fazla Süreci Olabilir)
            builder.HasMany(u => u.UserQuitProgresses)
                .WithOne(qp => qp.User)
                .HasForeignKey(qp => qp.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
