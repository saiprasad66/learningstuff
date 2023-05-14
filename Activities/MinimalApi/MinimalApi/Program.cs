using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TrainerContext>(options =>
options.UseInMemoryDatabase("TrainerList"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/Trainer/get", async (TrainerContext tc) =>
await tc.trainers.ToListAsync());

app.MapGet("/Trainer/{id}", async (int id, TrainerContext tc) =>
await tc.trainers.FindAsync(id));


app.Run();

class Trainer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string password { get; set; }
}

class TrainerContext : DbContext
{
    public TrainerContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Trainer> trainers { get; set; }
}

