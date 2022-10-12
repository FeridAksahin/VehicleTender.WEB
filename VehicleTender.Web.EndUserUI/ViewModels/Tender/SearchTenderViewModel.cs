using System;

namespace VehicleTender.Web.EndUserUI.ViewModels.Tender
{
    public class SearchTenderViewModel
    {
        // ihale aramak için kullanılır.
        public string TenderName { get; set; }  // filtre için
        public int StatuId { get; set; }    // filtre için
    }
}