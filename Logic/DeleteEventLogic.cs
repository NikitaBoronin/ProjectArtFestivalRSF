using System;

namespace ArtFestival.Logic
{
    public class DeleteEventLogic
    {
        private readonly IArtFestivalDbContext Db;

        public DeleteEventLogic(IArtFestivalDbContext db)
        {
            Db = db;
        }

        public string? DeleteEvent(Event ev)
        {
            if (ev == null)
                return "Сначала выберите событие для удаления.";

            Db.Events.Remove(ev);
            Db.SaveChanges();
            return "Событие успешно удалено";
        }
    }
}
