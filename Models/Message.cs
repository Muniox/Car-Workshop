namespace CarWorkshop.Presentation.Models
{
    public class Message
    {
        public string? Title { get; set; }
        public string? Descritpion { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
    }
}
