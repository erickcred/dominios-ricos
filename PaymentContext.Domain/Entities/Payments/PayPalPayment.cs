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
      string document,
      string address,
      string email,
      string transactionCode
    ) : base(paiDate, expireDate, total, totalPaid, payer, document, address, email)
    {
      TransactionCode = transactionCode;
    }

    public string TransactionCode { get; private set; } 
  }
}