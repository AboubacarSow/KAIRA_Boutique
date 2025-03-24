using KAIRA.Data.Context;
using KAIRA.Features.CQRS.Handlers.CategoryHandlers;
using KAIRA.Repositories.Contracts;
using KAIRA.Repositories.Models;
using Microsoft.EntityFrameworkCore;

namespace KAIRA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<RepositoryContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            builder.Services.AddScoped<GetCategoryQueryHandler>();
            builder.Services.AddScoped<GetCategoryByIdQueryHandler>();
            builder.Services.AddScoped<CreateCategoryCommandHandler>();
            builder.Services.AddScoped<UpdateCategoryCommandHandler>();
            builder.Services.AddScoped<RemoveCategoryCommandHandler>();
            builder.Services.AddScoped<IRepositoryService, RepositoryManager>();
                
            var app = builder.Build();

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
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
             );
            

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
