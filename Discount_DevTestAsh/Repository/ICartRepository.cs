using DiscountDevTestAsh.Model;

namespace DiscountDevTestAsh.Repository
{
    /// <summary>
    /// Cart repo interface
    /// </summary>
    public interface ICartRepository
    {
        int CreateCartNew();
        void AddCartItem(LineItem product);
        void RemoveCartItem(int productID);
        Cart GetCartByID(int cartID);
    }
}
