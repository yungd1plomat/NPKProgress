namespace NPKProgress.Models
{
    public class Disease
    {
        public string Id { get; set; }

        public string Description { get; set; }

        public List<Attendance> Attendances { get; set; }
    }
}
