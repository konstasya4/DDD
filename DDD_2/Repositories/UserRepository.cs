using DDD_2.Agregate;
namespace DDD_2.Repositories;
public class UserRepository
{
    private readonly List<User> users = new();

    public User GetUserById(int id) => users.FirstOrDefault(c => c.Id == id);

    public ICollection<User> GetUser() => users;
    public void AddUser(User user) => users.Add(user);
}