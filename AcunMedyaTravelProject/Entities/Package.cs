namespace AcunMedyaTravelProject.Entities
{
    public class Package
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int DestinationId { get; set; }
        public int DayCount { get; set; }
        public int PersonCount { get; set; }
        public string HotelName { get; set; }
        public int HotelStar { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public Destination Destination { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
