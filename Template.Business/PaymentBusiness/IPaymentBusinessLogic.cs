using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Model.PaymentModels;

namespace Template.Business.PaymentBusiness
{
    public interface IPaymentBusinessLogic
    {
        Task<bool> AddPayment(PaymentModel model);
    }
}
