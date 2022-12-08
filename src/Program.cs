using NoteAppApi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<NoteContext>(options =>
{
	var folder = Environment.SpecialFolder.LocalApplicationData;
	var path = Environment.GetFolderPath(folder);
	string DbPath = System.IO.Path.Join(path, "Note.db");
	options.UseSqlite($"Data Source={DbPath}");
});
// Uncomment to use an in memory db
// builder.Services.AddDbContext<NoteContext>(options =>
// {
// 	options.UseInMemoryDatabase("NoteApp");
// });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
