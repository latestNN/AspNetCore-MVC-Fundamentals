 using P07_Route_Yapilanmasi.Constraints;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();
        builder.Services.Configure<RouteOptions>(options =>{ options.ConstraintMap.Add("custom", typeof(CustomConstrains)));

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseRouting();

        app.UseAuthorization();

        app.MapStaticAssets();

        app.MapControllerRoute("ConstraintRoute", "{controller=Home}/{Action=Index}/{id:int?}/{name:maxlenght(12)?}/{tc:custom"); // 
        app.MapControllerRoute("ConstraintRoute", "{controller=Home}/{Action=Index}/{id:int?}/{name:maxlenght(12)?}/{tc:int:length(11)}"); // 
        app.MapControllerRoute("ConstraintRoute", "{controller=CustomRouteController}/{Action=TypeSafeRoute}/{id:int?}/{name?}"); // 
        app.MapControllerRoute("DataRoute", "{controller=CustomRouteController}/{action=Index}/{x}/{y}/{id?}");
        app.MapControllerRoute("AnasayfaRoute", "Anasayfa", new { controller = "Home", action = "Index" });  // Anasayfa Url'sine girince Home Controller'ý altýndaki Index Action'ýna yönlendirir.
        app.MapControllerRoute("CustomRouteListe", "{controller=Product}/{action=Listele}");  // default product controller olur.
        app.MapControllerRoute("CustomRouteAction", "{action}/{controller}");   // Index / Home beklenir
        app.MapControllerRoute("CustomRouteMAL", "{action}/SaDunya/{controller}"); // Index / SaDunya / Home þeklinde çalýþýr. Yani arada SaDunya deðeri olamayan hiçbir Request kaþýlanmaz.
        app.MapDefaultControllerRoute(); // Mimarinin default olarak ayarladýðý rotadýr.
        app.MapControllers();





        app.Run();
    }
}