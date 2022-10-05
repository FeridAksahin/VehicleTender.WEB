﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
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
        private readonly VehicleService _vehicleService;
        public VehicleController()
        {
            _vehicleService = new VehicleService();
        }

        // GET: Vehicle
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> ListVehicle()
        {
            List<VehicleListViewModel> list = await _vehicleService.GetListAsync(null);
            VehicleViewModel vehicleViewModel = new VehicleViewModel
            {
                VehicleList = list
            };
            return View(vehicleViewModel);
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
        public async Task<ActionResult> ListVehicle(GetVehicleListInput input)
        {
            List<VehicleListViewModel> list = await _vehicleService.GetListAsync(input);
            VehicleViewModel vehicleViewModel = new VehicleViewModel
            {
                VehicleList = list
            };
            return View(vehicleViewModel);
        }



        [HttpGet]
        public ActionResult PostingSalesAdvertisement()
        {
            return View();
        }

    }
}