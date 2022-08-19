namespace NLayer.Core
{
    public class Store : BaseEntity
    {
        public string Name { get; set; }
        public int CompanyVat { get; set; }
        public string CompanyName { get; set; }
        public int CompanyPhoneNumber { get; set; }
        public string CompanyEmail { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}