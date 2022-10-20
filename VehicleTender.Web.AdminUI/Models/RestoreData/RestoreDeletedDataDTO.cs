using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.RestoreData
{
    public class RestoreDeletedDataDTO
    {
        [StringType(Max = 20, Min = 1)]
        public string No { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string DataType { get; set; }
        public DateTime DeleteDate { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string DeleteBy { get; set; }

    }
}
