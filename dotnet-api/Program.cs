
using dotnet_api.DataAcces;
using dotnet_api.Logic;
using Microsoft.EntityFrameworkCore;

namespace dotnet_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<HockeyPlayerContext>(o=>o.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection")));
            builder.Services.AddControllers();

            builder.Services.AddScoped<IPlayerLogic, PlayerLogic>();
            builder.Services.AddAutoMapper(typeof(Program));

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
