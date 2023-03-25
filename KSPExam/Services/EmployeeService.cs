using KSPExam.DAL;
using KSPExam.Models;

namespace KSPExam.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly MyDbContext _myDbContext;

        public EmployeeService(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _myDbContext.Employees.ToList();
        }
        public Employee AddEmployee(Employee employee)
        {
            var result = _myDbContext.Employees.Add(employee);
            _myDbContext.SaveChanges();
            return result.Entity;
        }

        public Employee GetEmployeeById(int id)
        {
            return _myDbContext.Employees.Where(x => x.Id == id).FirstOrDefault();
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var result = _myDbContext.Employees.Update(employee);
            _myDbContext.SaveChanges();
            return result.Entity;
        }
    }
}
