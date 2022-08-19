namespace NLayer.Core
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }//*

        public Category Category { get; set; }

        //@TODO:StoreId 'de olursa daha iyi olur.
        //Store için eklendi.
        public Store Store { get; set; }


        public ProductFeature ProductFeature { get; set; }
    }
}
