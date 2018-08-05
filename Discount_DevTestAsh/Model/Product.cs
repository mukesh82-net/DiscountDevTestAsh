using DiscountDevTestAsh.DiscountRules;

namespace DiscountDevTestAsh.Model
{
    /// <summary>
    /// Product item model
    /// </summary>
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public IDiscount IDiscount { get; set; }
    }
}
