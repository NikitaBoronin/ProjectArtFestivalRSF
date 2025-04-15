using ArtFestival.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class EventUserConfiguration : IEntityTypeConfiguration<EventUser>
{
    public void Configure(EntityTypeBuilder<EventUser> builder)
    {
        builder.HasKey(ep => new { ep.EventID, ep.UserID });

    }
}
