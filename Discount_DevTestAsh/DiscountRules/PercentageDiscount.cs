using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscountDevTestAsh.Model;

namespace DiscountDevTestAsh.DiscountRules
{
    /// <summary>
    /// Percetage discount on cart item.
    /// </summary>
    class PercetageDiscount : IDiscount
    {
        readonly double _discountPerc;
        public PercetageDiscount()
        {
            this._discountPerc = 10.00;
        }

        public PercetageDiscount(double discountAmt)
        {
            this._discountPerc = discountAmt;
        }

        /// <summary>
        /// Calculate Percetage discount of cart item.
        /// </summary>
        /// <param name="lineItem">LineItem object.</param>
        public void CalcDicount(LineItem lineItem)
        {
            try
            {
                //Rule: provide Percetage discount if item price is 100 or more.
                if (lineItem.Price >= 100)
                {
                    lineItem.Discount = lineItem.Cost * (this._discountPerc / 100);
                    lineItem.Cost = lineItem.Cost - lineItem.Discount;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
