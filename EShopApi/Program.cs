using ApplicationCore.Interfaces.Repository;
using ApplicationCore.Interfaces.Service;
using Infrastructure.Data;
using Infrastructure.Repository;
using Infrastructure.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddDbContext<EShopDbContext>(option => {
    option.UseSqlServer(builder.Configuration.GetConnectionString(""));

});
builder.Services.AddScoped<IRegionServiceAsync, RegionServiceAsync>();

builder.Services.AddScoped<IRegionRepositoryAsync, RegionRepositoryAsync>();



var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
