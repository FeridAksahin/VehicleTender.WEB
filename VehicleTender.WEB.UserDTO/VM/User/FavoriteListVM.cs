using System;
namespace VehicleTender.WEB.UserDTO.VM.User
{
    public class FavoriteListVM
    {
        public int UserId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string StatuName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string PreAssessmentPrice { get; set; }
    }
}
