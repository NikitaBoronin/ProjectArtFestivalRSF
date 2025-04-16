public class Event
{
    public int EventID { get; set; }
    public DateTime EventDate { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public byte[]? ImageData { get; set; }
    public ICollection<EventUser> Users { get; set; }
}