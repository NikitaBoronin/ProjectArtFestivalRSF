using ArtFestival;
using ArtFestival.Model;


public static class DataInitializer
{
    public static List<string> Categories = new()
    {
        "Классическая живопись", "Современное искусство",
        "Театральное искусство", "Скульптура и инсталляции"
    };

    public static async Task SeedTestData(ArtFestivalDbContext context)
    {
        if (!context.Users.Any())
        {
            var users = new List<User>
            {
                new() { Name = "Иван Петров" },
                new() { Name = "Мария Сидорова" }
            };
            await context.Users.AddRangeAsync(users);
            await context.SaveChangesAsync();
        }
    }
}