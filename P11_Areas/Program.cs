var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.MapControllerRoute(
    name: "areaDefault",
    pattern: "{area:exists}/{controller= Home}/{action=Index}/{id?}" // Default Area Route'u tanýmlama
    );

app.MapAreaControllerRoute(
    name: "areaRoute1",
    areaName: "yonetim",
    pattern: "yonetim_sayfasi/{controller=Home}/{action=Index}/{id?}" // Area özel Route tanýmlama. yonetim Attribute'u ile iþaretlenmiþ Controller'lar, yonetim_sayfasi ile baþlayan Url'ler ile tetiklenir. 
    );

app.MapAreaControllerRoute(
    name: "areaRoute2",
    areaName: "fatura_paneli",
    pattern: "fatura/{controller=Home}/{action=Index}"
    );

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
