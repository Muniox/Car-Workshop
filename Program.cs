using CarWorkshop.Application.Extensions;
using CarWorkshop.Infrastructure.Extensions;
using CarWorkshop.Infrastructure.Seeders;

namespace CarWorkshop.Presentation
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container. 
            builder.Services.AddControllersWithViews();

            builder.Services.AddInfrastructure(builder.Configuration);
            builder.Services.AddApplication();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope()) // Use using statement for proper disposal
            {
                var services = scope.ServiceProvider;
                var seeder = services.GetRequiredService<CarWorkshopSeeder>();
                await seeder.Seed(); // Await the async method
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            await app.RunAsync();
        }
    }
}
