using System;

namespace VehicleTender.API.DTO.EndUserDTO.VM.Tender
{
    public class TenderListVM
    {
        public int Id { get; set; }
        public string TenderName { get; set; }
        public string IndividualOrCorparate { get; set; }
        public string TenderStartDate { get; set; }
        public string TenderEndDate { get; set; }
        public string CreatedBy { get; set; }
        public string Statu { get; set; }
        public string CreatedDate { get; set; }
    }
}
