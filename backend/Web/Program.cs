using System.Reflection;
using Application.Parts.Mapping;
using Application.Parts.Services;
using Application.Works.Services;
using Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

// Add services to the container.

services.AddControllers();
services.Configure<RouteOptions>(options => options.LowercaseUrls = true);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen(options =>
{
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory,
        $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"));
});

// Adding DB
services.AddDbContext<DataContext>(options =>
{
    options
        .UseNpgsql(configuration.GetConnectionString("Postgres"))
        // .EnableSensitiveDataLogging()
        .UseSnakeCaseNamingConvention()
        ;
});

// Adding Mapping
services.AddAutoMapper(
    typeof(PartsMappingProfile).Assembly,
    typeof(Web.Mapping.PartsMappingProfile).Assembly
);

// Adding Application Services
services.AddTransient<IPartsService, PartsService>();
services.AddTransient<IWorksService, WorksService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app
    .UseSwagger()
    .UseSwaggerUI()
    .UseAuthorization();

app.MapControllers();

app.Run();