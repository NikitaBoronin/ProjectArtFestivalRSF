using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class EventUserConfiguration : IEntityTypeConfiguration<EventUser>
{
    public void Configure(EntityTypeBuilder<EventUser> builder)
    {
        builder.HasKey(eu => new { eu.EventID, eu.UserID });

        builder.HasOne(eu => eu.Event)
            .WithMany(e => e.Users)
            .HasForeignKey(eu => eu.EventID)
            .HasConstraintName("FK_EventUsers_Events")
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(eu => eu.User)
            .WithMany(u => u.Events)
            .HasForeignKey(eu => eu.UserID)
            .HasConstraintName("FK_EventUsers_Users")
            .OnDelete(DeleteBehavior.Cascade);
    }
}