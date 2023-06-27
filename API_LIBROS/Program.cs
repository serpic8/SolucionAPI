using API_LIBROS;
using API_LIBROS.Data;
using API_LIBROS.Repository;
using API_LIBROS.Repository.IRepository;
using API_LIBROS.Security;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddAutoMapper(typeof(MappingConfig));  

builder.Services.AddScoped<ILibrosRepository, LibrosRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();  //Para la autenticacion

builder.Services.AddAuthentication("BasicAuthentication")  //Authentication
    .AddScheme<AuthenticationSchemeOptions, BasicAuthHandler>
    ("BasicAuthentication", null);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication(); //Para authenticacion

app.UseAuthorization();

app.MapControllers();

app.Run();
