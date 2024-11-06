namespace HMS.Models 
{
    public class Appointment
    {
        public int Id {get; set; }
        public int DoctorId {get; set; }
        public int PatientId {get; set; }
        public string Date {get; set; }
        public string Time {get; set;}
    }
}