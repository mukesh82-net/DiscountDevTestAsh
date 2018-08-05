using DiscountDevTestAsh.Model;

namespace DiscountDevTestAsh.DiscountRules
{
    /// <summary>
    /// Cart item discount.
    /// </summary>
    public interface IDiscount
    {        
        void CalcDicount(LineItem lineItem);
    }
}
