using Ddd.Domain.Interfaces;
using Ddd.Domain.Services;
using Ddd.Infrastructure.Data;
using Ddd.Infrastructure.Interfaces;
using Ddd.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// builder.Services.AddScoped<Ddd.Infrastructure.Data.AppDbContext>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Setting Dependency Injector IOC 

//Database connection
builder.Services.AddDbContext<AppDbContext>();
// (options =>
// {
//     options.UseSqlServer(builder.Configuration["SqlConnection:SqlConnectionString"]);
// });

// builder.Services.AddScoped<Ddd.Infrastructure.Data.AppDbContext>();

builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IUserRepository, UserRepository>();


builder.Services.AddControllers();
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
