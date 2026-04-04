using Day04.Data;
using Day04.Data.DbContexts;
using Day04.Models;
using System.Net;

namespace Day04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Seed randomized data on first run (skips if DB already has records)
            /*using (var scope = app.Services.CreateScope())
            {
                var db = new CollegeSystemDbContext();
                DatabaseSeeder.Seed(db);
            }*/

            app.Run();
        }
    }
}
