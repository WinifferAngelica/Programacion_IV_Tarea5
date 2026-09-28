using WebApi.Data;
using Microsoft.AspNetCore.Http.HttpResults;


namespace WebApi;

public class Program
{

    private const string BlazorClientPolicy = "BlazorClientPolicy";

    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.


        builder.Services.AddControllers();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddScoped<DapperDB>();

        builder.Services.AddCors(options =>
        {
            options.AddPolicy(BlazorClientPolicy, policy =>
            {
                policy.AllowAnyOrigin()
                      .AllowAnyHeader()
                      .AllowAnyMethod();
            });
        });


        var app = builder.Build();

        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

        app.UseCors("BlazorClientPolicy");

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();

    }
}