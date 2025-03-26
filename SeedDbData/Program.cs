using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SeedDbData
{
    internal class Program(IServiceCollection services)
    {

        static void Main(string[] args)
        {

            var options = new DbContextOptionsBuilder<SeedDataDbContext>()
                .UseSqlServer("").Options;

            using var context = new SeedDataDbContext(options);

            Console.WriteLine("Press 1 to seed data");
            string key = Console.ReadLine();
            if (key == "1")
            {
                SeedDatabase(context);
                Console.WriteLine("Database seeded successfully!");
            }

        }
        private static void SeedDatabase(SeedDataDbContext context)
        {
            if (!context.HockeyPlayers.Any())
            {
                var players = SeedData.GetSeedData();
                context.HockeyPlayers.AddRange(players);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Database already seeded.");
            }
        }
    }
}
