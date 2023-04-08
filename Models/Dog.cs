namespace DogGo.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public string Breed { get; set; }
        public string? Notes { get; set; } = null;
        public string? ImageUrl { get; set; } = null;
        public string DisplayImage => ImageUrl ?? "https://cdn-icons-png.flaticon.com/512/1596/1596810.png";
    }
}
