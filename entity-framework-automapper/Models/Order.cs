namespace entity_framework_automapper.Models
{
    public class Order
    {
        public Product product { get; set; } = new Product();
        public Customer customer { get; set; } = new Customer();
    }
}
