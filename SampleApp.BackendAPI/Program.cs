using Serilog;
using Microsoft.AspNetCore.StaticFiles;
using SampleApp.BackendAPI.Services;
using SampleApp.BackendAPI.Models;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File("logs/cityinfo.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


#if DEBUG
builder.Services.AddScoped<IMailServices, LocalMailService>();
#else
builder.Services.AddScoped<IMailServices, CloudMailServices>();
#endif

builder.Services.AddScoped<ISamurai, SamuraiService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Host.UseSerilog();

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

app.Run();
