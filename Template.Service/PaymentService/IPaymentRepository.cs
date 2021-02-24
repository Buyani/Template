using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;

namespace Template.Service.PaymentService
{
    public interface IPaymentRepository
    {
        Task<Payment> GetPaymentByIdAsync(string id);
        Task<List<Payment>> GetAllPaymentsAsync();
        Task InsertPaymentAsync(Payment payment);
        Task UpdatePaymentAsync(Payment student);
        Task DeletePaymentAsync(Payment student);
    }
}
