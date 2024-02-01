using System.Linq.Expressions;
using Core.Entities.OrderAggregate;

namespace Core.Specifications
{
    public class OrderByPaymentIntentIdSpec : BaseSpecification<Order>
    {
        public OrderByPaymentIntentIdSpec(string PaymentIntentId) : base(o => o.PaymentIntentId == PaymentIntentId)
        {
        }
    }
}