using ArtFestival.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class EventUserConfiguration : IEntityTypeConfiguration<EventUser>
{
    public void Configure(EntityTypeBuilder<EventUser> builder)
    {
        builder.HasKey(ep => new { ep.EventID, ep.UserID });
        builder.HasOne<Event>()
               .WithMany()
               .HasForeignKey(ep => ep.EventID);

        builder.HasOne<User>()
               .WithMany()
               .HasForeignKey(ep => ep.UserID);
    }
}