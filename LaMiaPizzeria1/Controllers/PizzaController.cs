using Microsoft.AspNetCore.Mvc;

namespace LaMiaPizzeriaModel.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
