﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Business.StudentBusiness;
using Template.Model.StudentModels;
using Template.Service.StudentService;

namespace Template.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudentController
        private readonly IStudentBusinessLogic _studentbusiness;
        public StudentController(IStudentBusinessLogic studentbusiness)
        {
            _studentbusiness = studentbusiness;
        }
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(StudentModel model)
        {
            try
            {
                await _studentbusiness.InsertStudent(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
