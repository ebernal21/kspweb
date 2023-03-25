namespace KSPExam.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public string Fullname { get; set; }
        public string Jobtitle { get; set; }
        public decimal Salary { get; set; }
        public bool Status { get; set; }
        public DateTime Hiredate { get; set; }
    }
}
