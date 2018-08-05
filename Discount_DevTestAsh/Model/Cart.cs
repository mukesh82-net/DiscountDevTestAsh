using DiscountDevTestAsh.DiscountRules;
using System.Collections.Generic;

namespace DiscountDevTestAsh.Model
{
    /// <summary>
    /// Cart model
    /// </summary>
    public class Cart
    {
        public int CartID { get; set; }
        public List<LineItem> LineItems { get; set; }
        public double CartDiscountTotal { get; set; }
        public double CartTotal { get; set; }

        public ICartDiscount ICartDiscount { get; set; }

        /// <summary>
        /// Display Cart property with custom string.
        /// </summary>
        /// <returns>LineItem custom string.</returns>
        public override string ToString()
        {
            return string.Format("CartID: {0} Total Items: {1} Total Discount: {2} Total: {3}", CartID, LineItems.Count, CartDiscountTotal, CartTotal);
        }
    }
}
