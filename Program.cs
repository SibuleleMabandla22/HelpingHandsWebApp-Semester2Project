using HelpingHandsWebApp.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//DBContext Configuration
builder.Services.AddDbContext<AppDBContext>(options => 

options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"))

);

//Seeding Data - commented out, it stopped working
//builder.Services.AddScoped<AppDbInitializer>();  ---

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
//SeedDatabase();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

//seed database method

AppDbInitializer.Seed(app);

//void SeedDatabase() 
//{
//    using (var scope = app.Services.CreateScope())
//    {
//        var dbInitializer = scope.ServiceProvider.GetRequiredService<AppDbInitializer>();
        
//    }
//}

