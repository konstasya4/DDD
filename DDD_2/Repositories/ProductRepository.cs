using DDD_2.Agregate;
namespace DDD_2.Repositories;
public class ProductRepository
{
    private readonly List<Product> products = new();

    public Product GetProductById(int id) => products.FirstOrDefault(c => c.Id == id);

    public ICollection<Product> GetProduct() => products;
    public void AddProduct(Product product) => products.Add(product);
}
