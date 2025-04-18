using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ArtFestival.Logic
{
    public class AddEventLogic
    {
        private readonly IArtFestivalDbContext Db;

        public AddEventLogic(IArtFestivalDbContext db)
        {
            Db = db;
        }

        public string? AddEvent(string title, string description, DateTime date,
                                string category, List<User> selectedUsers, string? imagePath)
        {
            if (string.IsNullOrWhiteSpace(title))
                return "Введите название события";
            if (string.IsNullOrWhiteSpace(description))
                return "Введите описание события";
            if (selectedUsers.Count == 0)
                return "Выберите хотя бы одного участника";
            if (string.IsNullOrEmpty(imagePath) || !File.Exists(imagePath))
                return "Сначала добавьте изображение";

            byte[] imageData = File.ReadAllBytes(imagePath);

            var newEvent = new Event
            {
                Title = title,
                Description = description,
                EventDate = date.ToUniversalTime(),
                Category = category,
                ImageData = imageData,
                Users = selectedUsers.Select(u => new EventUser { UserID = u.UserID }).ToList()
            };

            bool exists = Db.Events.Any(ev => ev.Title == newEvent.Title &&
                                               ev.EventDate.Date == newEvent.EventDate.Date);
            if (exists)
                return "Такое событие уже есть!";

            Db.Events.Add(newEvent);
            Db.SaveChanges();
            return "Событие успешно добавлено";
        }
    }
}
