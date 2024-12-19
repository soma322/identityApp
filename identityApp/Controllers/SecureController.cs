using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace identityApp.Controllers
{
    [Authorize]
    public class SecureController : Controller
    {
        public IActionResult Index() { return View(); }
    }
}
