using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Business.SubjectBusiness;
using Template.Model.SubjectModels;

namespace Template.Controllers
{
    [Authorize]
    public class SubjectController : Controller
    {
        private readonly ISubjectbusinessLogic _subjectbusiness;
        public SubjectController(ISubjectbusinessLogic subjectbusiness)
        {
            _subjectbusiness = subjectbusiness;
        }
        public async Task<ActionResult>Index()
        {
            return View(await _subjectbusiness.AllSubjects());
        }
        public async Task<ActionResult> Create()
        {
            return View();
        }
        // POST: SubjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task< ActionResult> Create(SubjectModel model)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "make sure all fields are filled");
                    return View(model);
                }
                await _subjectbusiness.InsertSubject(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
