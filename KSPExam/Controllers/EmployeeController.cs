using KSPExam.DAL;
using KSPExam.Models;
using KSPExam.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KSPExam.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeService employeeService;
        public EmployeeController(IEmployeeService _employeeService)
        {
            employeeService = _employeeService;
        }

        [HttpGet]
        public IEnumerable<Employee> EmployeeList()
        {
            var humans = employeeService.GetAllEmployees();
            return humans;
        }

        [HttpPost]
        public Employee AddEmployee(Employee employee)
        {
            return employeeService.AddEmployee(employee);
        }

        [HttpGet]
        public Employee GetEmployeeById(int Id)
        {
            return employeeService.GetEmployeeById(Id);
        }

        [HttpPut]
        public Employee UpdateEmployee(Employee employee)
        {
            return employeeService.UpdateEmployee(employee);
        }
    }
}
