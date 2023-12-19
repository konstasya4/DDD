using DDD_2.Agregate;
namespace DDD_2.Repositories;

public class OrderRepository
{
    private readonly List<Order> orders = new();
    public Order GetOrderById(int id) => orders.FirstOrDefault(c => c.Id == id);

    public ICollection<Order> GetOrder() => orders;
    public void AddOrder(Order order) => orders.Add(order);
}