using DDD_2.Agregate;
using DDD_2.Factories;
using DDD_2.Repositories;
var productFactory = new ProductFactory();
var orderFactory = new OrderFactory();
var userFactory = new UserFactory();

var productRepository = new ProductRepository();
var orderRepository = new OrderRepository();
var userRepository = new UserRepository();


User user = userFactory.CreateUser(
    "Анастасия",
    "Константинова",
    "Мир",
    "Наличными"
);

userRepository.AddUser(user);

Console.WriteLine("Добавлен пользователь:");
Console.WriteLine($"Имя: {user.Name}\nФамилия: {user.LastName}\nТип карты: {user.CardType}\nСпособ оплаты: {user.PaymentMethod}\n");

Product product = productFactory.CreateProduct(
    "Чай
    120
    );

productRepository.AddProduct(product);

var listProducts = new List<Product>() { product };

var address = new Address()
{
    City = "Москва
    Street = "Космонавтов"
    HomeNumber = 11
};

Order order = orderFactory.CreateOrder(1,listProducts, "Доставлено"  ,address);
orderRepository.AddOrder(order);
Console.WriteLine("Заказ создан:");
Console.WriteLine($"Индетификатор пользователя: {order.UserId}\nСписок товаров: {product.Title}, {product.Price}\nСтатус заказа: {order.OrderStatus}\nАдрес доставки:\nГород: {address.City}\nУлица: {address.Street}\nНомер дома: {address.HomeNumber}");