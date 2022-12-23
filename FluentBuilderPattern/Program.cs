using FluentBuilderPattern;

var products = new List<Product>() { new Product() { Id = 1, Name = "Product 1", Price = 10 },
                                    new Product() { Id = 2, Name = "Product2", Price = 30 },
                                    new Product() { Id = 3, Name = "Product3", Price = 40 } };
var customer = new Customer() { Id = 1, Name = "Shiva" };

var shoppingCard = new ShoppingCardFluentBuilder()
                    .WithId(Guid.NewGuid())
                    .WithProducts(products)
                    .WithCustomer(customer)
                    .WithDiscount(3)
                    .Build();

Console.WriteLine(shoppingCard.ToString());
