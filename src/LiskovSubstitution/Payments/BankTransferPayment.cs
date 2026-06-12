namespace LiskovSubstitution.Payments
{
    using LiskovSubstitution.Contracts;
    using LiskovSubstitution.Models;

    public sealed class BankTransferPayment : IPaymentMethod
    {
        public PaymentReceipt Pay(Order order)
        {
            return new PaymentReceipt(order.Number, "Bank transfer", order.Total, "BT-90314");
        }
    }
}
