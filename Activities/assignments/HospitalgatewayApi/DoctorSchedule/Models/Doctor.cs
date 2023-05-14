namespace DoctorSchedule.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Speciality { get; set;}

        public DateTime Avaiability { get; set;}

    }
}
