using Microsoft.AspNetCore.Mvc;

namespace VehicleTender.API.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        /// <summary>
        /// All User actions will be done here.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
