namespace FluentBuilderPattern
{
    public class ShoppingCardFluentBuilder
    {
        private ShoppingCard _shoppingCard = new ShoppingCard();

        public ShoppingCardFluentBuilder WithId(Guid id)
        {
           _shoppingCard.Id = id;
            return this;
        }

        public ShoppingCardFluentBuilder WithProducts(List<Product> products)
        {
            _shoppingCard.Products = products;
            return this;
        }

        public ShoppingCardFluentBuilder WithDiscount(double discount)
        {
            _shoppingCard.Discount = discount;
            return this;
        }

        public ShoppingCardFluentBuilder WithCustomer(Customer customer)
        {
            _shoppingCard.Customer = customer;
            return this;
        }

        public ShoppingCard Build()
        {
            return _shoppingCard;
        }
    }
}
