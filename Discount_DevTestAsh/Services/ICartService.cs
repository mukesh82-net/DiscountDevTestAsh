using DiscountDevTestAsh.Model;

namespace DiscountDevTestAsh.Services
{
    /// <summary>
    /// Cart service interface that provides abstraction for cart service.
    /// </summary>
    public interface ICartService
    {
        int CreateCartNew();
        void AddCartItem(int productID, int quantity);
        void AddFreeCartItem(int productID, int quantity);
        Cart CheckOutCart(int cartID);
    }
}
