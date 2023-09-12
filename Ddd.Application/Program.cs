using Ddd.Domain.Interfaces;
using Ddd.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// builder.Services.AddScoped<Ddd.Infrastructure.Data.AppDbContext>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Setting Dependency Injector
builder.Services.AddSingleton<IUserService, UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger(options => { options.RouteTemplate = "swagger/{documentname}/swagger.json"; });
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("./v1/swagger.json", "Industrial Passport API");
    options.RoutePrefix = "swagger";
});

app.UsePathBase(new PathString("/api"));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
