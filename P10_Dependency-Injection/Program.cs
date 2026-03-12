using P10_Dependency_Injection.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.Add(new ServiceDescriptor(typeof(ConsoleLog), new ConsoleLog()));
builder.Services.Add(new ServiceDescriptor(typeof(TextLog), new TextLog(),ServiceLifetime.Transient));

builder.Services.AddSingleton<TextLog>(); // Sadece tek bir tane nesne oluþturucak ve her isteðe yaný nesneyi göndericek.
builder.Services.AddScoped<TextLog>(); // Her istek için yeni bir nesne oluþturur ve o istekteki tüm ihtiyaçlara/taleplere ayný nesneyi gönderir.
builder.Services.AddTransient<TextLog>(); // Her istek için yeni bir nesne oluþturur ve o istekteki tüm ihtiyaçlara/taleplere farklý nesneler gönderir. Yani her talep için yeni bir nesne oluþturur.

builder.Services.AddSingleton<ConsoleLog>(p => new ConsoleLog(5)); //Consturactor parametre alýyorsa. Bu kullaným tüm davranýþlar için geçerlidir.


builder.Services.AddScoped<ILog>(p => new ConsoleLog(5)); // Interface üzerinden de ekleme yapabiliriz. Bu durumda sadece ConsoleLog sýnýfýna sahip nesneler oluþturulabilir ve ILog türünde isteklerde bu nesneler gönderilir.
builder.Services.AddScoped<ILog, ConsoleLog>(); // Bu kullanýmda da ConsoleLog sýnýfýna sahip nesneler oluþturulabilir ve ILog türünde isteklerde bu nesneler gönderilir. Bu kullanýmda ConsoleLog sýnýfýnýn parametre almayan bir constructor'ý olmasý gerekir.

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
