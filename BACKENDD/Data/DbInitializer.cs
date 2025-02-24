using BACKENDD.Models;
using System.Linq;

namespace BACKENDD.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {

            // Если таблица Contacts не пуста, то выходим

            // Иначе добавляем несколько начальных данных
            var contacts = new Contact[]
            {
                new Contact { Name = "Иван", SecName = "Иванов", Age = 30, Email = "ivan@example.com", Message = "Привет!" },
                new Contact { Name = "Мария", SecName = "Петрова", Age = 25, Email = "maria@example.com", Message = "Как дела?" }
            };

            context.Contacts.AddRange(contacts);
            context.SaveChanges();  // Сохраняем изменения
        }
    }
}
