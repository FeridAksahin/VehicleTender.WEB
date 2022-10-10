using Microsoft.AspNetCore.Mvc;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class ComissionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(object Data)
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            return View();
        }
      
        public IActionResult Update(int id)
        {
            return View();
        }


        [HttpPut]
        public IActionResult Update(object data)
        {
            return View();
        }
    }
}
