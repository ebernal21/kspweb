using System.ComponentModel;

namespace WebMVCKsp.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        [DisplayName("Foto")]
        public string Photo { get; set; }
        [DisplayName("Nombre completo")]
        public string Fullname { get; set; }
        [DisplayName("Puesto")]
        public string Jobtitle { get; set; }
        [DisplayName("Salario")]
        public decimal Salary { get; set; }
        [DisplayName("Estatus")]
        public bool Status { get; set; }
        [DisplayName("Fecha contratacion")]
        public DateTime Hiredate { get; set; }
    }
}
