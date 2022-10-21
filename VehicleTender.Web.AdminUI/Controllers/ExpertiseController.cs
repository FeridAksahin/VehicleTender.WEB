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

        BearerTokenDTO token=new BearerTokenDTO();
        

        [HttpGet]
        public async Task<IActionResult> Expertise(string name,string district, string city)
        {

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
            await expertiseService.AddExpertise(token, expertisePageModel.getExpertise);
            return RedirectToAction(nameof(Expertise));
        }
        [HttpGet]
        public async Task<IActionResult> UpdateExpertise(int id)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateExpertise(ExpertisePageModel expertisePageModel)
        {
            await expertiseService.UpdateExpertise(token, expertisePageModel.getExpertise);
            return RedirectToAction(nameof(Expertise));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteExpertise(int id)
        {
            await expertiseService.DeleteExpertise(token,id);
            return RedirectToAction(nameof(Expertise));
        }
    }
}
