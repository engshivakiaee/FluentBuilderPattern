namespace FluentBuilderPattern
{
    public class ShoppingCard
    {
        public Guid Id { get;set; }
        public IEnumerable<Product>? Products { get; set; }
        public double Discount { get; set; }
        public Customer? Customer { get; set; }

        public override string ToString()
        {
            return $"----------Shopping Card----------\n\nCustomer : {Customer.Name}\n\nItems :\n\n" +
                string.Join("", Products.Select(p => p.ToString())) +
                $"Discount : ${this.Discount}\n\n";
        }
    }
}
