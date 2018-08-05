using System;
using DiscountDevTestAsh.Model;

namespace DiscountDevTestAsh.DiscountRules
{
    /// <summary>
    /// Flat discount on cart item.
    /// </summary>
    class FlatDiscount : IDiscount
    {
        readonly double _discountAmt;
        public FlatDiscount()
        {
            this._discountAmt = 10.00;
        }

        public FlatDiscount(double discountAmt)
        {
            this._discountAmt = discountAmt;
        }

        /// <summary>
        /// Calculate flat discount of cart item.
        /// </summary>
        /// <param name="lineItem">LineItem object.</param>
        public void CalcDicount(LineItem lineItem)
        {
            try
            {
                //Rule: provide discount if item price is 100 or more.
                if (lineItem.Price >= 100)
                {
                    lineItem.Discount = this._discountAmt;
                    lineItem.Cost -= this._discountAmt;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
