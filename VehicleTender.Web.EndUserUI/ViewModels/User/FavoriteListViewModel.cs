using System;
namespace VehicleTender.Web.EndUserUI.ViewModels.User
{
    public class FavoriteListViewModel
    {
        public int UserId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string StatuName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string PreAssessmentPrice { get; set; }
    }
}