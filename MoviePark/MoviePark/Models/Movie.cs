namespace MoviePark.Models
{
    public class Movie
    {
        public int Id { get; set; }  
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Genre { get; set; }
        public string Cast { get; set; }
        public string Director { get; set; }
        public decimal Price { get; set; }  
        public double Rating { get; set; }
        public int Runtime { get; set; }
        public int ReleaseYear { get; set; }
    }
}

