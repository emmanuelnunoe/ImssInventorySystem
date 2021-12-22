namespace ImssInventory.API.Models
{
    public class User
    {
        public int userId { get; set; }
        public string Name { get; set; }
        public string Sourname { get; set; }
        public string? SecondSourname { get; set; }
        public int EnrollmentId { get; set; }
        public string Phone { get; set; }
        public Position Position { get; set; }
        public int PositionId { get; set; }
        public string? Nomination { get; set; }
        public byte Active { get; set; }
    }
}
