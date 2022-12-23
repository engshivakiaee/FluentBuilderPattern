using System.Reflection.Metadata.Ecma335;

namespace FluentBuilderPattern
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return String.Join(Environment.NewLine, $"Id : {this.Id}, Name : {this.Name}, Price : ${this.Price}\n\n");
        }
    }
}
