using Microsoft.EntityFrameworkCore;

namespace ArtFestival
{
    public interface IArtFestivalDbContext
    {
        DbSet<User> Users { get; }
        DbSet<Event> Events { get; }
        DbSet<EventUser> EventUsers { get; }
        int SaveChanges();
    }
}
