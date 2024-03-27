namespace Student_Management_System.Models.Entities
{
    public class Student
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool isSubscribed { get; set; }
    }
}
