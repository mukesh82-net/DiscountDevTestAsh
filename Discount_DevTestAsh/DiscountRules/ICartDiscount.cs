using DiscountDevTestAsh.Model;
using DiscountDevTestAsh.Services;

namespace DiscountDevTestAsh.DiscountRules
{
    /// <summary>
    /// Interface of cart discount.
    /// </summary>
    public interface ICartDiscount
    {
        void CalcDicount(Cart cart, ICartService cartService);
    }
}
