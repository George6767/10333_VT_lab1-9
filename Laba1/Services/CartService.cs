using Laba1.DAL.Entities;
using Laba1.Extensions;
using Laba1.Models;
using System.Text.Json.Serialization;

namespace Laba1.Services
{
    public class CartService : Cart
    {
        private string sessionKey = "cart";

        [JsonIgnore]
        ISession Session { get; set; }
        public static Cart GetCart(IServiceProvider sp)
        {
            var session = sp
                .GetRequiredService<IHttpContextAccessor>()
                .HttpContext
                .Session;
            var cart = session?.Get<CartService>("cart")
            ?? new CartService();
            cart.Session = session;
            return cart;
        }
        public override void AddToCart(Dish dish)
        {
            base.AddToCart(dish);
            Session?.Set<CartService>(sessionKey, this);
        }
        public override void RemoveFromCart(int id)
        {
            base.RemoveFromCart(id);
            Session?.Set<CartService>(sessionKey, this);
        }
        public override void ClearAll()
        {
            base.ClearAll();
            Session?.Set<CartService>(sessionKey, this);
        }
    }
}
