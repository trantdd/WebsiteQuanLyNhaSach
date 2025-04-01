using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebsiteQuanLyNhaSach.Models;
using WebsiteQuanLyNhaSach.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Cấu hình database
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Cấu hình Identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders()
    .AddDefaultUI();

builder.Services.AddRazorPages();

// Thêm các dịch vụ cần thiết
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ILoaiSPRepository, EFLoaiSPRepository>();

var app = builder.Build();

// Cấu hình pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication(); // Bắt buộc khi dùng Identity
app.UseAuthorization();

app.UseStaticFiles(); // Để hỗ trợ file tĩnh như CSS, JS, ảnh

// Cấu hình route cho Areas
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=HomeAdmin}/{action=Index}/{id?}");

// Cấu hình route mặc định
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages(); // Để hỗ trợ Razor Pages

app.Run();
