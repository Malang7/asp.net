using Microsoft.AspNetCore.Mvc;

namespace calculator.Controllers
{
    public class calculatorController : Controller
    {
        public IActionResult calculator()
        {
            return View();
        }
    }

}