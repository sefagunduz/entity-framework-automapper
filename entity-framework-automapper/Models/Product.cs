namespace entity_framework_automapper.Models
{
    public class Product
    {
        public Guid ID { get; set; }
        public string Name { get; set; } = "";
        public int Count { get; set; }
        public DateTime RecordDate { get; set; }
    }
}
