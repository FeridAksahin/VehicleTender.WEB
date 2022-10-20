using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VehicleTender.API.Validation;
using VehicleTender.Web.AdminUI.ApiServices.Services;
using VehicleTender.Web.AdminUI.Models.Admin;
using VehicleTender.Web.AdminUI.Models.Commission;
using VehicleTender.Web.AdminUI.Models.PageModel;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class CommissionController : Controller
    {
        CommissionService commissionService= new();
        BearerTokenDTO token = new BearerTokenDTO();
        CommissionPageModel commissionPageModel = new CommissionPageModel();

        [HttpGet]
        public async Task<IActionResult> Commission()
        {
            commissionPageModel.CommissionList = new List<CommissionDTO>();
            //commissionPageModel.CommissionList = await commissionService.GetAllCommission(token);
            CommissionDTO commissionDTO = new CommissionDTO()
            {
                ID=1,
                CarStartingPrice = "0",
                CarEndingPrice = "300000",
                CommissionPrice = 5000,
                EndDate= DateTime.Now.AddDays(500),
            };
            commissionPageModel.CommissionList.Add(commissionDTO);

            return View(commissionPageModel);
        }
        [HttpPost]
        public async Task<IActionResult> AddCommission(CommissionPageModel commissionPageModel)
        {
            await commissionService.AddNewCommission(token, commissionPageModel.AddCommission);
            return RedirectToAction(nameof(Commission));
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCommission(CommissionPageModel commissionPageModel)
        {
            await commissionService.UpdateCommission(token, commissionPageModel.UpdateCommission);
            return RedirectToAction(nameof(Commission));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteCommission(int id)
        {
            await commissionService.DeleteCommission(token, id);
            return RedirectToAction(nameof(Commission));
        }
    }
}
