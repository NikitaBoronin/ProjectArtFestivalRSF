using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ArtFestival.Logic
{
    public class EditEventLogic
    {
        private readonly IArtFestivalDbContext Db;

        public EditEventLogic(IArtFestivalDbContext db)
        {
            Db = db;
        }

        public string? EditEvent(Event selectedEvent, string title, string description,
                                 DateTime date, string category, ICollection<EventUser> selectedUsers,
                                 string? imagePath = null)
        {
            if (selectedEvent == null)
                return "Выберите событие для редактирования.";

            if (string.IsNullOrWhiteSpace(title))
                return "Название события пустое";
            if (string.IsNullOrWhiteSpace(description))
                return "Описание события пустое";
            if (selectedUsers.Count == 0)
                return "Выберите хотя бы одного участника";


            bool isChanged = true;

            // Проверяем текстовые поля на изменения
            if (selectedEvent.Title == title && selectedEvent.Description == description && selectedEvent.EventDate == date && selectedEvent.Category == category && selectedEvent.Users == selectedUsers)
            {
                isChanged = false;
            }
            if (!isChanged)
            {
                return "Вы не внесли изменений";
            }

            selectedEvent.Title = title;
            selectedEvent.Description = description;
            selectedEvent.EventDate = date.ToUniversalTime();
            selectedEvent.Category = category;

            selectedEvent.Users.Clear();
            foreach (var user in selectedUsers)
            {
                selectedEvent.Users.Add(new EventUser { UserID = user.UserID });
            }

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                selectedEvent.ImageData = File.ReadAllBytes(imagePath);
            }


            Db.SaveChanges();
            return "Событие успешно изменено";

        }
    }
}
