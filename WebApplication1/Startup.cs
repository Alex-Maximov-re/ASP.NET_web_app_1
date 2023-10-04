namespace WebApplication1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)  //есть конструктор который принимает конфигурацию (свойство) и потом устанавливает внутри конструктра
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }  //конфигурация интерфейса, хранит настройки приложения, 


        /*public void Configure(IApplicationBuilder app, IWebHostEnvironment env)  //метод нужен для подключения необходимых компонентов
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler();
            }
        }*/
    }
}
