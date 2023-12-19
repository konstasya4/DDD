using Microsoft.VisualBasic;

namespace DDD_2.Agregate;
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string CardType { get; set; }
    public string PaymentMethod { get; set; }
     public ICollection<Order> Orders { get; set; }
}