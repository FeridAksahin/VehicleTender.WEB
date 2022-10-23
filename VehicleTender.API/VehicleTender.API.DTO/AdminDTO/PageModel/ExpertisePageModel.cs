using VehicleTender.API.DTO.AdminDTO.Models.Expertise;

namespace VehicleTender.API.DTO.AdminDTO.Models.PageModel
{
    public class ExpertisePageModel
    {
        public GetExpertise getExpertise { get; set; }
        public List<GetExpertise> getExpertiseList { get; set; }
        public ExpertiseSearch expertiseSearch { get; set; }

    }
}
