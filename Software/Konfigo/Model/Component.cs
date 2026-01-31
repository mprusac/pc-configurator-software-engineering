namespace Konfigo.Model
{
    public class Component
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ComponentTypeId { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public string Manufacturer { get; set; }         
        public string Specifications { get; set; }

       public string TypeName { get; set; }

 


    }
}
