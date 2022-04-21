using Microsoft.AspNetCore.Mvc;

namespace BOOKSTORE.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountsController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
