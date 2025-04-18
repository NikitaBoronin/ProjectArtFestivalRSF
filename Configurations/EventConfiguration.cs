using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.HasKey(e => e.EventID);
        builder.Property(e => e.EventID)
            .ValueGeneratedOnAdd();

        builder.Property(e => e.EventDate)
            .HasColumnType("timestamp with time zone");
    }
}