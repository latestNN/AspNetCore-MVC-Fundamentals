using P08._02_Custom_Route_Handler.Handlers;

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

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.Map("example-route1", async c =>
{
    //http://localhost:5000/example-route endpointine gelen istekler Controller'a gitmez onun yerine buradaki fonksiyonu çalýþtýrýr.
});

app.Map("example-route", new ExampleHandler().Handler());

app.Map("image/{imageName}", new ImageHandler().Handler(app.Environment.WebRootPath));

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
