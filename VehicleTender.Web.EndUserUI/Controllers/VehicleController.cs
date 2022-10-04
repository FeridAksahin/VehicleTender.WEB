using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
<<<<<<< HEAD
=======
using VehicleTender.Web.EndUserUI.ApiService.Concrete;
using VehicleTender.Web.EndUserUI.ApiService.Interface;
>>>>>>> 90dcbff9a7892079e832329b14fd7f3d777ecebd
using VehicleTender.Web.EndUserUI.ViewModels;

namespace VehicleTender.Web.EndUserUI.Controllers
{
    public class VehicleController : Controller
    {
        private readonly RequestApiSerivce _requestApiService;
        public VehicleController()
        {
            string apiUrl = ConfigurationManager.AppSettings["ApiUrl"];
            _requestApiService = new RequestApiSerivce(apiUrl);
        }

        // GET: Vehicle
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ListVehicle()
        {
            return View();
        }
<<<<<<< HEAD
        [HttpGet]
        public ActionResult AddVehicle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddVehicle(VehicleAddViewModel vehicleAddViewModel)
        {
            return View();
=======

        [HttpPost]
        public ActionResult ListVehicle(GetVehicleListInput input)
        {
            string apiUrl = ConfigurationManager.AppSettings["ApiUrl"];
            string endpoint = apiUrl+ "Vehicle/GetIndex?marka=" + input.Brand + "&model=" + input.Model + "&isIndividual=" + input.isIndividual + "&status=" + input.Status;

            var deger = _requestApiService.GetRequest<GetVehicleListInput>(endpoint);
            return View(deger);
>>>>>>> 90dcbff9a7892079e832329b14fd7f3d777ecebd
        }
    }
}