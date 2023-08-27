using PaymentContext.Domain.Entities.Payments;

namespace PaymentContext.Domain.Entities
{
  public class Subscription
  {
    public DateTime CreateDate { get; private set; }
    public DateTime LastUpdateDate { get; private set; }
    public DateTime? ExpireDate { get; private set; }
    public bool Active { get; private set; }
    public IReadOnlyCollection<Payment> Payments { get { return _payments.ToArray(); } }

    private IList<Payment> _payments { get; set; }

    public Subscription(DateTime? expireDate)
    {
      CreateDate = DateTime.Now;
      LastUpdateDate = DateTime.Now;
      ExpireDate = expireDate;
      Active = true;
      _payments = new List<Payment>();
    }

    public void AddPayment(Payment payment)
    {
      _payments.Add(payment);
    }

    public void Activate(bool status)
    {
      Active = status;
      LastUpdateDate = DateTime.Now;
    }

  }
}