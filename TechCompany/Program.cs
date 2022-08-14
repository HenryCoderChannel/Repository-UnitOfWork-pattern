using Entities.Context;
using Microsoft.EntityFrameworkCore;
using Repository.RepositoryManager;
using Service.IService;
using Service.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<TechCompanyContext>(opt =>
                    opt.UseSqlServer(
                            builder.Configuration.GetConnectionString("TechCompanyConnection"),
                            m => m.MigrationsAssembly("TechCompany")
                    ));

builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<ICompanyService, CompanyService>();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
