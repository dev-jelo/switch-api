using Microsoft.EntityFrameworkCore;
using switchAPI.Contexts;
using switchAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSqlite<SwitchesContext>("Data Source=.\\Database\\switches.db");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/switches", async (SwitchesContext db) =>
{
    return await db.Switches.ToListAsync();
});

app.MapGet("/switches/{id}", async (string id, SwitchesContext db) =>
{   
    List<Switch> switchDetails = await db.Switches.Where(x => x.Id == id).ToListAsync();
    return switchDetails.Count == 0 ? Results.NotFound() : Results.Ok(switchDetails);

});

app.Run();