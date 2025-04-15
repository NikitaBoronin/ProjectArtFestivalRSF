using ArtFestival.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class EventUserConfiguration : IEntityTypeConfiguration<EventUser>
{
    public void Configure(EntityTypeBuilder<EventUser> builder)
    {
        builder.HasKey(eu => new { eu.EventID, eu.UserID });

        // Явно задаем имена ограничений
        builder.HasOne<Event>()
            .WithMany(e => e.Users)
            .HasForeignKey(eu => eu.EventID)
            .HasConstraintName("FK_EventUsers_Events")
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey(eu => eu.UserID)
            .HasConstraintName("FK_EventUsers_Users")
            .OnDelete(DeleteBehavior.Cascade);
    }
}