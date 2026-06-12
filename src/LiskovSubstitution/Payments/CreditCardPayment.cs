namespace LiskovSubstitution.Payments
{
    using LiskovSubstitution.Contracts;
    using LiskovSubstitution.Models;

    public sealed class CreditCardPayment : IPaymentMethod
    {
        public PaymentReceipt Pay(Order order)
        {
            return new PaymentReceipt(order.Number, "Credit card", order.Total, "CC-77881");
        }
    }
}
