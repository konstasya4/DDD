using DDD_2.Agregate;

namespace DDD_2.Factories;
public class UserFactory
{
    private int id = 0;
    public User CreateUser(string name, string lastName, string cardType, string paymentMethod)
    {
        var user = new User()
        {
            Id = id,
            Name = name,
            LastName = lastName,
            CardType = cardType,
            PaymentMethod = paymentMethod
        };
        id++;
        return user;
    }
}
