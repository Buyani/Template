using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Business.EnrollementBusiness;
using Template.Business.FormerSchoolBusiness;
using Template.Business.GuardianBusiness;
using Template.Business.StudentBusiness;
using Template.Business.SubjectBusiness;
using Template.Model.StudentModels;
using Template.Model.SubjectModels;
using Template.Service.StudentService;

namespace Template.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        // GET: StudentController
        private readonly IStudentBusinessLogic _studentbusiness;
        private readonly ISubjectbusinessLogic _subjectbusiness;
        private readonly IGuardianBusinessLogic _guardianbusiness;
        private readonly ISchoolBusinessLogic _schoolbusiness;
        private readonly IEnrollementBusinessLogic _enrollementbusiness;
        public StudentController(IStudentBusinessLogic studentbusiness, ISubjectbusinessLogic subjectbusiness,
            IGuardianBusinessLogic guardianbusiness, ISchoolBusinessLogic schoolbusiness, IEnrollementBusinessLogic enrollementbusiness)
        {
            _studentbusiness = studentbusiness;
            _subjectbusiness = subjectbusiness;
            _guardianbusiness = guardianbusiness;
            _schoolbusiness = schoolbusiness;
            _enrollementbusiness = enrollementbusiness;
    }
        public async Task<ActionResult>Index(string Search_Data)
        { 
            var students = await _studentbusiness.AllStudentsAsync();
            if(Search_Data!=null)
            {
                students = students.Where(stu => stu.FirstName.ToLower().Contains(Search_Data.ToUpper())
                 || stu.Identity.ToUpper().Contains(Search_Data.ToUpper()) || stu.Surname.ToUpper().Contains(Search_Data.ToUpper())).ToList();
            }
            return View(students.ToList());
        }
        public async Task<ActionResult> Create()
        {
            var studentmodel = new StudentModel
            {
                Subjects = await _subjectbusiness.AllSubjects(),
            };
            return View(studentmodel);
        }
        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(StudentModel model)
        {
            model.Subjects = model.Subjects;
            try
            {
                if (ValidateSubjects(model.Subjects) && ! ModelState.IsValid)
                {
                    model.Subjects = model.Subjects;
                    ModelState.AddModelError("", "Student can only register for 3 or less subjects");               
                    return View(model);
                }
                var guard_identity = await _guardianbusiness.InsertGuardianAsync(model);
                var schoolid =Convert.ToInt16(await _schoolbusiness.InsertSchoolAsync(model));
                var identity=await _studentbusiness.InsertStudentAsync(model,guard_identity,schoolid);
                await _enrollementbusiness.InsertChosenSubjects(model.Subjects, identity);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                model.Subjects = model.Subjects;
                return View();
            }
        }
        public async Task<ActionResult> StudentProfile(string Identity)
        {
            var profife = await _studentbusiness.GetStudentByIdentityAsync(Identity);
            return View(profife);
        }
        private bool ValidateSubjects(List<SubjectViewModel> list)
        {
            if(list.Where(p => p.CheckboxAnswer.Equals(true)).Count()>3)
            {
                return true;
            }
            return false;
        }
    }
}
