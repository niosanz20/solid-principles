namespace LiskovSubstitution.Contracts
{
    using LiskovSubstitution.Models;

    public interface IPaymentMethod
    {
        PaymentReceipt Pay(Order order);
    }
}
