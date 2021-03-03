using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Business.PaymentBusiness;
using Template.Business.StudentBusiness;
using Template.Model.PaymentModels;
using Template.Model.StudentModels;

namespace Template.Controllers
{
    [Authorize]
    public class PaymentController : Controller
    {
        private readonly IPaymentBusinessLogic _paymentbusiness;
        private readonly IStudentBusinessLogic _studentsbusiness;
        public PaymentController(IPaymentBusinessLogic paymentbusiness, IStudentBusinessLogic studentsbusiness)
        {
            _paymentbusiness = paymentbusiness;
            _studentsbusiness = studentsbusiness;


        }
        // GET: PaymentController/Create
        public ActionResult Create(string Identity)
        {
            var payemnt = new PaymentModel
            {
                StudentIdentity = Identity
            };
            return View(payemnt);
        }
        // POST: PaymentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PaymentModel model)
        {
            try
            {
                if(!await _paymentbusiness.AddPayment(model))
                {
                    ModelState.AddModelError("", "Student Identity not found");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public async Task<IActionResult> Students(string term)
        {
            List<StudentViewModel> list = await _studentsbusiness.AllStudentsAsync();
            return Json(list.Where(p=>p.FirstName.StartsWith(term, StringComparison.CurrentCultureIgnoreCase)).ToArray());
        }

    }
}
