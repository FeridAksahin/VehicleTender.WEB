using VehicleTender.API.Validation.Attributes;
namespace VehicleTender.API.DTO.AdminDTO.Models.RestoreData
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
