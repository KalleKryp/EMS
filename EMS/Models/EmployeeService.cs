using EMS.Models.Entities;
using EMS.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class EmployeeService
    {
        //public List<Employee> employees = new List<Employee>();

        //static int idCounter = 1;

        private MyContext context;

        public EmployeeService(MyContext context)
        {
            this.context = context;
        }
        public void AddEmployee(EmployeesCreateVM viewModel)
        {
            //emp.ID = idCounter++;
            context.Employees.Add( new Employee
            {
                Name = viewModel.Name,
                Email = viewModel.Email
            });

            context.SaveChanges();
        }

        public EmployeesIndexVM[] GetAllEmployees()
        {
            return context.Employees.Select(e => new EmployeesIndexVM
            {
                Id = e.Id,
                Name = e.Name,
                Email = e.Email,
                ShowAsHighlighted = e.Email.ToLower().StartsWith("admin")
            }).ToArray();
        }

        public Employee GetEmployeeById(int id)
        {
            return context.Employees.FirstOrDefault(e => e.Id == id);
        }
    }
}
