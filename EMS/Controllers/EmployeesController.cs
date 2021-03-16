using EMS.Models;
using EMS.Models.Entities;
using EMS.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Controllers
{
    public class EmployeesController : Controller
    {
        EmployeeService service;
        IContentService contentService;

        public EmployeesController(EmployeeService service, IContentService contentService)
        {
            this.service = service;
            this.contentService = contentService;
        }

        [Route("")]
        [Route("employees/index")]
        public IActionResult Index()
        {
            var emps = service.GetAllEmployees();
            return View(emps);
        }


        [Route("about")]
        public IActionResult About()
        {
            return View(contentService);
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
        public IActionResult Create(EmployeesCreateVM employee)
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
