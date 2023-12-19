using DDD_2.Agregate;

namespace DDD_2.Factories;
public class ProductFactory
{
    private int id = 0;
    public Product CreateProduct(string title, int price)
    {
        var product = new Product()
        {
            Id = id,
            Title = title,
            Price = price
        };
        id++;
        return product;
    }
}