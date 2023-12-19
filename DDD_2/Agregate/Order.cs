using Microsoft.VisualBasic;

namespace DDD_2.Agregate;
public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public ICollection<Product> Products { get; set; }
    public string OrderStatus { get; set; }
    public Address Address { get; set; }
}
public class Address
{
    public string City { get; set; }
    public string Street { get; set; }
    public int HomeNumber { get; set; }
}