using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TodoList.API.Context;
using TodoList.API.Repositories.Abstract;
using TodoList.API.Repositories.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TodoListContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnStr")));

builder.Services.AddTransient<ITaskModelRepository, TaskModelRepository>();
builder.Services.AddTransient<ISettingsModelRepository, SettingsModelRepository>();

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
