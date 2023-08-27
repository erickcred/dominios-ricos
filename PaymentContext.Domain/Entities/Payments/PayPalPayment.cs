using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities.Payments
{
  public class PayPalPayment : Payment
  {
    public PayPalPayment(
      DateTime paiDate,
      DateTime expireDate,
      decimal total,
      decimal totalPaid,
      string payer,
      Document document,
      Address address,
      Email email,
      string transactionCode
    ) : base(paiDate, expireDate, total, totalPaid, payer, document, address, email)
    {
      TransactionCode = transactionCode;
    }

    public string TransactionCode { get; private set; } 
  }
}