using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.Car
{
    public class CarStatuHistoryDTO
    {
        [StringType(Max = 20, Min = 1)]
        public string Statu { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
