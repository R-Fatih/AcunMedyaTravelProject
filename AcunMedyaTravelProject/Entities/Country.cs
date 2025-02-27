namespace AcunMedyaTravelProject.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Destination> Destinations { get; set; }
    }
}
