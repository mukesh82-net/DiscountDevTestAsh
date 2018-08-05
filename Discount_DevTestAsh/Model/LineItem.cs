namespace DiscountDevTestAsh.Model
{
    /// <summary>
    /// Cart item model
    /// </summary>
    public class LineItem
    {
        public LineItem()
        {
            this.LineItemType = LineItemTypes.OrderItem;
        }

        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }
        public LineItemTypes LineItemType  {get; set;}

        /// <summary>
        /// Display LineItem property with custom string.
        /// </summary>
        /// <returns>LineItem custom string.</returns>
        public override string ToString()
        {
            if (this.LineItemType == LineItemTypes.FreeItem)
                return string.Format("Free Item: ProductID: {0} Price: {1} Quantity: {2} Discount: {3}  Cost: {4}", ProductID, Price, Quantity, Discount, Cost);
            else
                return string.Format("ProductID: {0} Price: {1} Quantity: {2} Discount: {3}  Cost: {4}", ProductID, Price, Quantity, Discount, Cost);
        }

        public enum LineItemTypes
        {
            OrderItem,
            FreeItem
        }
    }
}
