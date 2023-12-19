using DDD_2.Agregate;

namespace DDD_2.Factories;
public class OrderFactory
{
    private int id = 0;
    public Order CreateOrder(int userId,List<Product> products, string orderStatus, Address address)
    {
        var order= new Order(){
        Id = id,
        UserId = userId,
        Products = products,
        OrderStatus = orderStatus,
        Address = address
        };
        id++;
        return order;
    }
}
