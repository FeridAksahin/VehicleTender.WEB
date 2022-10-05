using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehicleTender.Web.EndUserUI.ApiService.Concrete;
using VehicleTender.Web.EndUserUI.ApiService.Interface;
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
            string apiUrl = ConfigurationManager.AppSettings["ApiUrl"];
            string endpoint = apiUrl + "Vehicle/GetIndex";

            List<VehicleListViewModel> list = _requestApiService.GetRequest<List<VehicleListViewModel>>(endpoint).Result;
            VehicleViewModel vehicleViewModel = new VehicleViewModel
            {
                VehicleList = list
            };
            return View(vehicleViewModel);
        }

        [HttpPost]
        public ActionResult ListVehicle(GetVehicleListInput input)
        {
            string apiUrl = ConfigurationManager.AppSettings["ApiUrl"];
            string endpoint = apiUrl+ "Vehicle/GetIndex?marka=" + input.BrandId + "&model=" + input.ModelId + "&isIndividual=" + input.isIndividual + "&status=" + input.StatusId;

            List<VehicleListViewModel> list = _requestApiService.GetRequest<List<VehicleListViewModel>>(endpoint).Result;
            VehicleViewModel vehicleViewModel = new VehicleViewModel
            {
                VehicleList = list
            };
            return View(vehicleViewModel);
        }
    }
}