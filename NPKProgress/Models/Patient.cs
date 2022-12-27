using System.ComponentModel.DataAnnotations;

namespace NPKProgress.Models
{
    public class Patient
    {
        public string Id { get; set; }

        public string SurName { get; set; }

        public string Name { get; set; }

        public string MiddleName { get; set; }

        public DateTime Birthday { get; set; }

        public string Phone { get; set; }

        public List<Attendance> Attendances { get; set; }
    }
}
