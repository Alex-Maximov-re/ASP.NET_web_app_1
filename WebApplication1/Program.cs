using WebApplication1;

var builder = WebApplication.CreateBuilder(args);  //устанавливает корневой каталог, конфигурация, базовые натсройки, 

// Add services to the container.
builder.Services.AddControllersWithViews();  //подключение служб

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder().ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>();});  //подключаем класс стартап

app.Run();