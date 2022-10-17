using GeekStore.API.Core.Configurations;
using GeekStore.API.Core.Contracts;
using GeekStore.API.Core.Data.Models;
using GeekStore.API.Core.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString =
    builder.Configuration.GetConnectionString("GeekStore");

builder.Services.AddDbContext<GeeksStoreContext>(options => {
    options.UseSqlServer(connectionString);
});

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MapperConfig));
builder.Services.AddControllers();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();

