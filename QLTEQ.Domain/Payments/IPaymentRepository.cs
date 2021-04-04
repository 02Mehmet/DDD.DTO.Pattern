using System;
using System.Threading.Tasks;

namespace QLTEQ.Domain.Payments
{
    public interface IPaymentRepository
    {
        Task<Payment> GetByIdAsync(PaymentId id);

        Task AddAsync(Payment payment);
    }
}