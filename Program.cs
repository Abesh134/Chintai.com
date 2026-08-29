using CHINTAI.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);


// Database Connection

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));



// Identity Configuration

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{

    options.SignIn.RequireConfirmedAccount = false;

})
.AddEntityFrameworkStores<ApplicationDbContext>();



// MVC

builder.Services.AddControllersWithViews();



var app = builder.Build();



// Middleware


if (!app.Environment.IsDevelopment())
{

    app.UseExceptionHandler("/Home/Error");

    app.UseHsts();

}



app.UseHttpsRedirection();


app.UseStaticFiles();


app.UseRouting();



app.UseAuthentication();


app.UseAuthorization();



app.MapControllerRoute(

    name: "default",

    pattern: "{controller=Home}/{action=Index}/{id?}"

);



app.MapRazorPages();



app.Run();
