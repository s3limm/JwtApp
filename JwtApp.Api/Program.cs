using AutoMapper;
using JwtApp.Api.Core.Application.Interfaces;
using JwtApp.Api.Core.Application.Mappings;
using JwtApp.Api.Persistance.Context;
using JwtApp.Api.Persistance.Repositories;
using MediatR;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApiDbContext>(opt =>
{
    opt.UseSqlServer("Server =.\\SQLEXPRESS; Database = JwtAppApiDB; Trusted_Connection = True; TrustServerCertificate = True; ");
});

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(opt =>
{
    opt.AddProfiles(new List<Profile>()
    {
        new ProductProfile()
    }); 
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider
        .GetRequiredService<ApiDbContext>();

    // Here is the migration executed
    dbContext.Database.Migrate();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
