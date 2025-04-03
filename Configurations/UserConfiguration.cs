
using ArtFestival.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.UserID);
        builder.Property(u => u.UserID)
            .ValueGeneratedOnAdd();
        builder.HasMany(u => u.Events)
            .WithOne(ue => ue.User)
            .HasForeignKey(ue => ue.UserID);
        builder.HasData(
        new User { UserID = 1, Name = "Алмаз" },
        new User { UserID = 2, Name = "Олег" },
        new User { UserID = 3, Name = "Иван Иванов" },
        new User { UserID = 4, Name = "Айназ" },
        new User { UserID = 5, Name = "Никита" }
    );

    }
}