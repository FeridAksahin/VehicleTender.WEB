using VehicleTender.Web.AdminUI.Models.Expertise;

namespace VehicleTender.Web.AdminUI.Models.PageModel
{
    public class ExpertisePageModel
    {
        public GetExpertise getExpertise { get; set; }
        public List<GetExpertise> getExpertiseList { get; set; }
        public ExpertiseSearch expertiseSearch { get; set; }

    }
}
