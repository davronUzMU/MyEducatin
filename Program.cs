
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using MyEducatin.Data;
using System.Text.Json;

namespace MyEducatin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AppDbContext>(options =>
                 options.UseNpgsql(builder.Configuration.GetConnectionString("WebApiDatabase")));

            // Add services to the container.

            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();

             builder.Services.AddSwaggerGen();
           


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.UseStaticFiles();
            app.MapFallbackToFile("index.html"); // React uchun fallback


            app.Run();
        }
    }
}
