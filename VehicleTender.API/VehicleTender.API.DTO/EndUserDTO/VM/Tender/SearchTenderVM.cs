namespace VehicleTender.API.DTO.EndUserDTO.VM.Tender
{
    public class SearchTenderVM
    {
        // ihale aramak için kullanılır.
        public string TenderName { get; set; }  // filtre için
        public int StatuId { get; set; }    // filtre için
    }
}
