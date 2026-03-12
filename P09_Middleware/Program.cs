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



#region Run Middleware
app.Run(async c => { await c.Response.WriteAsync("Middleware 1"); }); // bu noktadan sonra hiçbir Middleware çalýþmaz. Pipeline tamamnlanýr ve Reponse dönülür.
app.Run(async c => { await c.Response.WriteAsync("Middleware 2"); });
#endregion


#region Use Middleware

app.Use(async (context, next) =>
{
    Console.WriteLine("Start Use Middleware");
    await next.Invoke(); // bir sonraki Middleware'e geçiþ yapar. Bu satýr olmazsa sonraki Middleware'ler çalýþmaz. Diðer Middleware'leri iþi birince tekrar bu noktaya geri döner.
    Console.WriteLine("Stop Use Middleware");

});

app.Run(async c =>
{
    Console.WriteLine("Run Middleware");
});

#endregion

#region Map Middleware
app.Map("/Merhaba", builder =>
{
    builder.Run(async c => await c.Response.WriteAsync("Merhaba tetiklendi"));
});
#endregion

#region MapWhen Middleware
app.MapWhen(c => c.Request.Method == "GET", builder =>
{
    builder.Run(async c => await c.Response.WriteAsync(" "));
});
#endregion




app.UseHttpsRedirection(); 
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run(); 
