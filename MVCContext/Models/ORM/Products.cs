namespace MVCContext.Models.ORM
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int UnitOnOrder { get; set; }
        public int Discounted { get; set; }
    }
}
