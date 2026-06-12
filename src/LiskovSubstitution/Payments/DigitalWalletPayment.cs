namespace LiskovSubstitution.Payments
{
    using LiskovSubstitution.Contracts;
    using LiskovSubstitution.Models;

    public sealed class DigitalWalletPayment : IPaymentMethod
    {
        public PaymentReceipt Pay(Order order)
        {
            return new PaymentReceipt(order.Number, "Digital wallet", order.Total, "DW-44120");
        }
    }
}
