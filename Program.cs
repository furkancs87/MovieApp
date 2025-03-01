using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// MVC servisini ekle
builder.Services.AddControllersWithViews();

var app = builder.Build();

// MVC için gerekli middleware’leri ekle
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); //www root klasörü dışarıya direkt açılmış oluyor. wwwroot => /css/style.css

app.UseStaticFiles(new StaticFileOptions{
    FileProvider = new PhysicalFileProvider(Path.Combine
    (Directory.GetCurrentDirectory(),"node_modules")),
    RequestPath = "/modules"
});

//modules/bootstrap/dist/css/bootstrap.min.css

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


/*var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
*/