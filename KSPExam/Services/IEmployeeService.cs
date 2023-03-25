using KSPExam.Models;

namespace KSPExam.Services
{
    public interface IEmployeeService
    {
        public IEnumerable<Employee> GetAllEmployees();
        public Employee AddEmployee(Employee employee);
        public Employee GetEmployeeById(int id);
        public Employee UpdateEmployee(Employee employee);
    }
}
