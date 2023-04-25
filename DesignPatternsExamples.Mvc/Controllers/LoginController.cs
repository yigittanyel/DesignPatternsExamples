using DesignPatternsExamples.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatternsExamples.Mvc.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GirisYap(User user)
        {
            if(user != null)
            {
                if(user.Username=="yigit" && user.Password == "yt123")
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
    }
}
