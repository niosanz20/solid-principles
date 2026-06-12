namespace LiskovSubstitution.Services
{
    using LiskovSubstitution.Contracts;
    using LiskovSubstitution.Models;

    public sealed class CheckoutService
    {
        public PaymentReceipt Pay(Order order, IPaymentMethod paymentMethod)
        {
            return paymentMethod.Pay(order);
        }
    }
}
