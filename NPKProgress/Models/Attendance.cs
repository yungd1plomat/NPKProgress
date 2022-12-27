namespace NPKProgress.Models
{
    public class Attendance
    {
        public string Id { get; set; }

        public DateTime Date { get; set; }

        public string Diagnosis { get; set; }

        public string PatientId { get; set; }

        public Patient? Patient { get; set; }

        public Disease? Disease { get; set; }
    }
}
