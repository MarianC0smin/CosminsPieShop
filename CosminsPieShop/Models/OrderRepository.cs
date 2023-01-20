namespace CosminsPieShop.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly CosminsPieShopDbContext _cosminsPieShopDbContext;
        private readonly IShoppingCart _shoppingCart;

        public OrderRepository(CosminsPieShopDbContext cosminsPieShopDbContext, IShoppingCart shoppingCart)
        {
            _cosminsPieShopDbContext = cosminsPieShopDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            List<ShoppingCartItem>? shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();

            foreach (ShoppingCartItem? shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    PieId = shoppingCartItem.Pie.PieId,
                    Price = shoppingCartItem.Pie.Price
                };

                order.OrderDetails.Add(orderDetail);
            }

            _cosminsPieShopDbContext.Orders.Add(order);

            _cosminsPieShopDbContext.SaveChanges();
        }
    }
}
