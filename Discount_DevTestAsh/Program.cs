using DiscountDevTestAsh.DiscountRules;
using DiscountDevTestAsh.Model;
using DiscountDevTestAsh.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountDevTestAsh
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ICartService mCartService = new CartService("Fake");
                //Create Cart
                int cartID = mCartService.CreateCartNew();

                //Add fake item to cart.
                mCartService.AddCartItem(1, 3);
                mCartService.AddCartItem(2, 3);
                mCartService.AddCartItem(3, 5);
                mCartService.AddCartItem(4, 3);
                mCartService.AddCartItem(5, 3);
                mCartService.AddCartItem(6, 3);
                mCartService.AddCartItem(7, 6);
                mCartService.AddCartItem(8, 6);
                mCartService.AddCartItem(9, 6);
                mCartService.AddCartItem(10, 6);

                //Process cart.
                Cart mCart = mCartService.CheckOutCart(cartID);

                //Print cart detail on screen.
                foreach (var item in mCart.LineItems)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(mCart.ToString());

                Console.ReadKey();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
