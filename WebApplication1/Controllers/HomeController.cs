using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        private readonly IConfiguration _configuration;  //создаем переменную из сеттингс (обязательно объявляем в конструкторе
        
        public IActionResult PrintInfo()  //создаем новый метод
        {
            return View();
        }

        public IActionResult Index()
        {
            var adminName = _configuration.GetSection("Admin:Name");  //обращаемся по ключу ""
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}