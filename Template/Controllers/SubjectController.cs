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
    public class SubjectController : Controller
    {
        private readonly ISubjectbusinessLogic _subjectbusiness;
        public SubjectController(ISubjectbusinessLogic subjectbusiness)
        {
            _subjectbusiness = subjectbusiness;
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
