using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehicleTender.Web.EndUserUI.ApiService.Concrete;
using VehicleTender.Web.EndUserUI.ApiService.Interface;
using VehicleTender.Web.EndUserUI.ApiService.RepoService;
using VehicleTender.Web.EndUserUI.ViewModels;

namespace VehicleTender.Web.EndUserUI.Controllers
{
    public class VehicleController : Controller
    {
        private readonly RequestApiService _requestApiService;
        public VehicleController()
        {
            string apiUrl = ConfigurationManager.AppSettings["ApiUrl"];
            _requestApiService = new RequestApiService(apiUrl);
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

        [HttpGet]
        public ActionResult AddVehicle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddVehicle(VehicleAddViewModel vehicleAddViewModel)
        {
            return View();
        }


        [HttpPost]
        public ActionResult ListVehicle(GetVehicleListInput input)
        {
            string apiUrl = ConfigurationManager.AppSettings["ApiUrl"];
            string endpoint = apiUrl + "Vehicle/GetIndex?marka=" + input.Brand + "&model=" + input.Model + "&isIndividual=" + input.isIndividual + "&status=" + input.Status;

            var deger = _requestApiService.GetAsync<GetVehicleListInput>(endpoint);
            return View(deger);
 
        }
    }
}