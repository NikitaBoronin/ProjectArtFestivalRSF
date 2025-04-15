using ArtFestival.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.HasKey(e => e.EventID);
        builder.Property(e => e.EventID)
            .ValueGeneratedOnAdd();

        builder.Property(e => e.EventDate)
            .HasColumnType("timestamp with time zone");

        // Настройка связи с EventUser
        builder.HasMany(e => e.Users)
            .WithOne()
            .HasForeignKey(eu => eu.EventID)
            .OnDelete(DeleteBehavior.Cascade);
    }
}