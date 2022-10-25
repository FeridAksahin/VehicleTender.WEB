using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using VehicleTender.Web.EndUserUI.ApiService.Concrete;
using VehicleTender.WEB.UserDTO.Concrete;
using VehicleTender.WEB.UserDTO.VM.Advert;
using VehicleTender.WEB.UserDTO.VM.Page;

namespace VehicleTender.Web.EndUserUI.Controllers
{
    public class AdvertListController : Controller
    {
        Token token = new Token();
        AdvertService advertService = new AdvertService();
        // GET: AdvertList
        public async Task<ActionResult> Index()
        {
            List<CarListVM> carListVMs = await advertService.CarListAdvert(token);
            return View(carListVMs);
        }

        public async Task<ActionResult> VehicleDetail(int id)
        {
            CarListVM carListVM = await advertService.CarDetail(token,id);
            return View(carListVM);
        }
    }

}