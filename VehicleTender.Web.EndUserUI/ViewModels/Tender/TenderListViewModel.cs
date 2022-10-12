using System;
namespace VehicleTender.Web.EndUserUI.ViewModels.Tender
{
    public class TenderListViewModel
    {
        public int Id { get; set; }
        public string TenderName { get; set; }
        public bool isIndividual { get; set; }
        public DateTime TenderStartDate { get; set; }
        public DateTime TenderEndDate { get; set; }
        public int UserId { get; set; }
        public int StatuId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}