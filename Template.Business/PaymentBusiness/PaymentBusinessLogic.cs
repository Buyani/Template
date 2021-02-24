using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;
using Template.Model.PaymentModels;
using Template.Service.PaymentService;
using Template.Service.StudentService;


namespace Template.Business.PaymentBusiness
{
    public class PaymentBusinessLogic : IPaymentBusinessLogic
    {

        private readonly IPaymentRepository _paymentservice;
        private readonly IStudentRepository _studentservice;

        public PaymentBusinessLogic(IPaymentRepository paymentservice, IStudentRepository studentservice)
        {
            _paymentservice = paymentservice;
            _studentservice = studentservice;
        }
        public async Task<bool> AddPayment(PaymentModel model)
        {
            var student = await _studentservice.GetStudentByIdAsync(model.StudentIdentity);

            if (student != null)
            {
                await _paymentservice.InsertPaymentAsync(new Payment
                {
                    StudentIdentity = student.Identity,
                    Amount = model.Amount,
                    Month = model.Paymentmonth.ToString(),
                    Paymenttype=model.Type.ToString()
                });
                return true;
            }
            return false;
        }

    }
}

