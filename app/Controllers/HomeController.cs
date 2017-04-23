using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace app
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;

        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        public IActionResult Index()
        {
            logger.LogInformation("catch!");
            HomeModel model = new HomeModel();
            model.Name = "timur";
            return View(model);
        }
    }
}