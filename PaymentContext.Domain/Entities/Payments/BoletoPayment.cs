using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities.Payments
{
  
  public class BoletoPayment : Payment
  {
    public BoletoPayment(
      DateTime paiDate,
      DateTime expireDate,
      decimal total,
      decimal totalPaid,
      string payer,
      Document document,
      Address address,
      Email email,
      string barCode,
      string boletoNumber
    ) : base(paiDate, expireDate, total, totalPaid, payer, document, address, email)
    {
      BarCode = barCode;
      BoletoNumber = boletoNumber;
    }

    public string BarCode { get; private set; }
    public string BoletoNumber { get; private set; }
  }
}