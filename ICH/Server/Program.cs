using ICH.DAL;
using ICH.Server;
using Microsoft.EntityFrameworkCore;
using NLog;
using Newtonsoft.Json.Serialization;


var builder = WebApplication.CreateBuilder(args);

LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

// Add services to the container.

builder.Services.AddDbContext<ICHDBContext>(opt => opt.UseSqlServer
    (builder.Configuration.GetConnectionString("ICHConnection")));

builder.Services.AddAppServices();

builder.Services.AddRazorPages();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddControllers().AddNewtonsoftJson(s => {
    s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
    s.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});
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

app.UseCors(options => options
            .WithOrigins("http://localhost:7040")
            .AllowAnyMethod()
            .AllowAnyHeader());


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
