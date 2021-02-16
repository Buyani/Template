using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Business.FormerSchoolBusiness;
using Template.Model.FormerSchoolModels;

namespace Template.Controllers
{
    public class SchoolController : Controller
    {

        private readonly IFormerSchoolBusinessLogic _schoolbusiness;
        public SchoolController(IFormerSchoolBusinessLogic schoolbusiness)
        {
            _schoolbusiness = schoolbusiness;
        }
        // GET: SchoolController/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: SchoolController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(FomerSchoolModel model)
        {
            try
            {
                await _schoolbusiness.InsertStudent(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}


