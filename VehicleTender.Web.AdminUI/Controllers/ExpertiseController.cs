using Microsoft.AspNetCore.Mvc;
using VehicleTender.API.Validation;
using VehicleTender.Web.AdminUI.ApiServices.Services;
using VehicleTender.Web.AdminUI.Models.Expertise;
using VehicleTender.Web.AdminUI.Models.PageModel;
using VehicleTender.Web.AdminUI.Models.Token;

namespace VehicleTender.Web.AdminUI.Controllers
{
    public class ExpertiseController : Controller
    {
        ExpertiseService expertiseService=new ExpertiseService();
        ExpertisePageModel model=new ExpertisePageModel();

        Token token=new Token();
        IHttpContextAccessor _httpContextAccessor;
        public ExpertiseController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public async Task<IActionResult> Expertise(string name,string district, string city)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            if (name!=null || district!=null || city!= null)
            {
                //model.getExpertiseList = await expertiseService.GetExpertiseBySearch(token, expertiseName + "," + city + "," + district);
                List<GetExpertise> getExpertises = new List<GetExpertise>();
                GetExpertise getExpertise = new GetExpertise()
                {
                    ExpertiseName="dasdasdsssss",
                    City="asdasd",
                    District="asdasd",
                    ExpertiseId=1,
                    Telephone = "asdasd",
                    Address = "asdasd",
                    
                };
                getExpertises.Add(getExpertise);
                model.getExpertiseList = getExpertises;
            }
            else
            {
                //model.getExpertiseList = await expertiseService.GetAllExpertise(token);
                List<GetExpertise> getExpertises = new List<GetExpertise>();
                GetExpertise getExpertise = new GetExpertise()
                {
                    ExpertiseName = "dasdasd",
                    City = "asdasd",
                    District = "asdasd",
                    ExpertiseId = 1,
                    Telephone = "asdasd",
                    Address = "asdasd",

                };
                getExpertises.Add(getExpertise);
                model.getExpertiseList = getExpertises;

            }
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddExpertise(ExpertisePageModel expertisePageModel)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            await expertiseService.AddExpertise(token, expertisePageModel.getExpertise);
            return RedirectToAction(nameof(Expertise));
        }
        [HttpGet]
        public async Task<IActionResult> UpdateExpertise(int id)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateExpertise(ExpertisePageModel expertisePageModel)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            await expertiseService.UpdateExpertise(token, expertisePageModel.getExpertise);
            return RedirectToAction(nameof(Expertise));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteExpertise(int id)
        {
            if (_httpContextAccessor.HttpContext.Request.Cookies["token"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            await expertiseService.DeleteExpertise(token,id);
            return RedirectToAction(nameof(Expertise));
        }
    }
}
