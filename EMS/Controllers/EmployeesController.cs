using EMS.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Controllers
{
    public class EmployeesController : Controller
    {
        EmployeeService service = new EmployeeService();

        [Route("")]
        [Route("employees/index")]
        public IActionResult Index()
        {
            var emps = service.GetAllEmployees();
            return View(emps);
        }


        [Route("employees/create")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        //En action - svarar på ett HTTP-anrop
        [Route("employees/create")]
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (!ModelState.IsValid)
                return View(employee);

            service.AddEmployee(employee);

            return RedirectToAction(nameof(Index));
        }

        [Route("employees/details/{id}")]
        public IActionResult Details(int id)
        {
            var emp = service.GetEmployeeById(id);
            return View(emp);
        }
    }
}
