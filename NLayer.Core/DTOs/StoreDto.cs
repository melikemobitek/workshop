namespace NLayer.Core.DTOs
{
    public class StoreDto : BaseDto
    {
        public string Name { get; set; }
        public int CompanyVat { get; set; }
        public string CompanyName { get; set; }
        public int CompanyPhoneNumber { get; set; }
        public string CompanyEmail { get; set; }
    }
}