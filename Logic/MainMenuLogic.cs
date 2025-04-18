using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArtFestival.Logic
{
    public class MainMenuLogic
    {
        private readonly IArtFestivalDbContext Db;

        public MainMenuLogic(IArtFestivalDbContext db)
        {
            Db = db;
        }

        public List<Event> FilterEvents(string? category, DateTime? date)
        {
            var query = Db.Events.Include(e => e.Users).AsQueryable();

            if (!string.IsNullOrEmpty(category) && category != "Все категории")
            {
                query = query.Where(ev => ev.Category == category);
            }

            if (date.HasValue)
            {
                var utcDate = date.Value.Date.ToUniversalTime();
                query = query.Where(ev => ev.EventDate.Date == utcDate.Date);
            }

            return query.OrderByDescending(ev => ev.EventDate).ToList();
        }


        public List<Event> GetAllEvents()
        {
            return Db.Events.Include(e => e.Users)
                             .OrderByDescending(e => e.EventDate)
                             .ToList();
        }
    }
}
