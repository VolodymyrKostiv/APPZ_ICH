using ICH.BLL.Interfaces.User;
using ICH.BLL.Interfaces.Vacancy;
using ICH.BLL.Services.User;
using ICH.BLL.Services.Vacancy;
using ICH.DAL;
using ICH.DAL.Repositories.Interfaces.User;
using ICH.DAL.Repositories.Interfaces.Vacancy;
using ICH.DAL.Repositories.Realizations.User;
using ICH.DAL.Repositories.Realizations.Vacancy;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ICHDBContext>(opt => opt.UseSqlServer
    (builder.Configuration.GetConnectionString("ICHConnection")));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IVacancyRepository, VacancyRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IVacancyService, VacancyService>();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
