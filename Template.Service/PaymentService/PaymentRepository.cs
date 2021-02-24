using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;
using Template.Data;

namespace Template.Service.PaymentService
{
    public class PaymentRepository : Repository<Payment>, IPaymentRepository
    {
        public PaymentRepository(MatricExcellenceDbContext context)
            : base(context)
        {
        }
        public async Task DeletePaymentAsync(Payment payment)
        {
            await DeleteAsync(payment);
        }

        public async Task<List<Payment>> GetAllPaymentsAsync()
        {
            return await GetAll().Include(p=>p.Student).ToListAsync();
        }
        public async Task<Payment> GetPaymentByIdAsync(string id)
        {
            return await GetAll().FirstOrDefaultAsync(p => p.Id.Equals(id));
        }

        public async Task InsertPaymentAsync(Payment payment)
        {
            await AddAsync(payment);
        }

        public async Task UpdatePaymentAsync(Payment payment)
        {
            await UpdateAsync(payment);
        }
    }
}
