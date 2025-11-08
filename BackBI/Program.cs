

using BackBI.Models;
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
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddControllers();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<DWContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DWConnection")));
            builder.Services.AddScoped<ISaleRepository ,SaleRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
