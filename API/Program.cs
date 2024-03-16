using Application.Profiles;
using Application.Services;
using Application.Services.Interfaces;
using Infra.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddAutoMapper(typeof(ClienteProfile), typeof(EnderecoProfile));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SeradDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "front-end",
                      policy  =>
                      {
                          policy.WithOrigins("https://sisserad1.onrender.com").AllowAnyMethod().AllowAnyHeader();;
                      });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors("front-end");

app.MapControllers();
app.UseHttpsRedirection();
app.Run();


