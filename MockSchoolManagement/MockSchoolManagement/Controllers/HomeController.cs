﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MockSchoolManagement.DataRepositories;
using MockSchoolManagement.Models;
using MockSchoolManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MockSchoolManagement.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentRepository _studentRepository=new MockStudentRepository();
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(IStudentRepository studentRepository, ILogger<HomeController> logger) 
        {
            _logger = logger;
            _studentRepository = studentRepository;
        }
        //public IActionResult Index()
        //{
        //    return "Hello from MVC";
        //    //return View();
        //}
        public ViewResult Index()
        {
            var model= _studentRepository.GetAllStudents();
            return View(model);
            //return View();
        }
        [HttpGet]
        public ViewResult Details(int? id) 
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel();
            homeDetailsViewModel.PageTitle = "学生详情";
            Student model=_studentRepository.GetStudent(id??1);
            homeDetailsViewModel.Student = model;
            return View(homeDetailsViewModel);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student) 
        {
            if (ModelState.IsValid)
            {
                Student newstudent = _studentRepository.Add(student);
                //return RedirectToAction("Details", new { id = newstudent.Id });
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
