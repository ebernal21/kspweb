namespace KSPExam.Models
{
    public class Beneficiary
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Relationship { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
    }
}
