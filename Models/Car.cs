namespace GregsListDotNet.Models
{
    public class Car
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int? Year { get; set; }
    }
}