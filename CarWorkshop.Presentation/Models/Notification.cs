namespace CarWorkshop.Presentation.Models
{
    public class Notification
    {
        public Notification(string type, string messgae)
        {
            Type = type;
            Message = messgae;
        }

        public string Type { get; set; }
        public string Message { get; set; }
    }
}
