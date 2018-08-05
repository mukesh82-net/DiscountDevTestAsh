using System;
using DiscountDevTestAsh.Model;

namespace DiscountDevTestAsh.DiscountRules
{
    /// <summary>
    /// Cart item group discount
    /// </summary>
    class GroupDiscount : IDiscount
    {
        readonly int _buyQuantity;
        readonly int _getFreeQuantity;

        public GroupDiscount()
        {
            this._buyQuantity = 5;
            this._getFreeQuantity = 1;
        }
        public GroupDiscount(int buyQuantity, int getFreeQuantity)
        {
            this._buyQuantity = buyQuantity;
            this._getFreeQuantity = getFreeQuantity;
        }

        /// <summary>
        /// Calculate cart item group discount.
        /// </summary>
        /// <param name="lineItem">LineItem object</param>
        public void CalcDicount(LineItem lineItem)
        {
            try
            {
                //Rule: add free item if item quantity is equal or great then provided
                if (lineItem.Quantity >= _buyQuantity)
                {
                    lineItem.Quantity += _getFreeQuantity;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
