using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class EmployeeService
    {
        public static List<Employee> employees = new List<Employee>();

        static int idCounter = 1;

        public void AddEmployee(Employee emp)
        {
            emp.ID = idCounter++;
            employees.Add(emp);
        }

        public Employee[] GetAllEmployees()
        {
            return employees.ToArray();
        }

        public Employee GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(e => e.ID == id);
        }
    }
}
