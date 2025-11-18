using BackBI.Models;
using BackBI.Repositories;
using BackBI.Repository;
using Microsoft.EntityFrameworkCore;

namespace BackBI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddSwaggerGen();
            builder.Services.AddOpenApi();

            builder.Services.AddDbContext<DWContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DWConnection")));

            builder.Services.AddScoped<ISaleRepository, SaleRepository>();
            builder.Services.AddScoped<IPurchaseRepository, PurchaseRepository>();

            // ---- Add CORS policy ----
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowLocalhost",
                    policy =>
                    {
                        policy.WithOrigins("http://localhost:8081") // your frontend URL
                              .AllowAnyHeader()
                              .AllowAnyMethod();
                    });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            // ---- Use CORS BEFORE MapControllers ----
            app.UseCors("AllowLocalhost");

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
