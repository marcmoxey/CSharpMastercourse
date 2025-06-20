using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVCMessageWall.Areas.Identity.Data;
using MVCMessageWall.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("MVCMessageWallContextConnection") ?? throw new InvalidOperationException("Connection string 'MVCMessageWallContextConnection' not found.");

builder.Services.AddDbContext<MVCMessageWallContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<MVCMessageWallUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<MVCMessageWallContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();


app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
  
    endpoints.MapRazorPages();
    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
});


app.Run();
