using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaApi.Controllers
{
    [ApiController]
    public class MagicVilla_VillaAPI : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
