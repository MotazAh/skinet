using System.Runtime.Serialization;

namespace Core.Entities.OrderAggregate
{
    public enum OrderStatus
    {
        [EnumMember(Value = "Pending")] // Force enum to return string "Pending" rather than 0
        Pending,
        [EnumMember(Value = "Payment Recieved")]
        PaymentRecieved,
        [EnumMember(Value = "Payment Failed")]
        PaymentFailed
    }
}