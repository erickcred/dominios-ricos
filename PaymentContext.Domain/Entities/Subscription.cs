using Flunt.Validations;
using PaymentContext.Domain.Entities.Payments;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
  public class Subscription : Entity
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
      AddNotifications(new Contract<string>()
        .Requires()
        .IsGreaterThan(DateTime.Now, payment.PaidDate, "Subscription.Payments", "A data do pagamento deve ser futura!")
      );

      if (IsValid)
        _payments.Add(payment);
    }

    public void Activate(bool status)
    {
      Active = status;
      LastUpdateDate = DateTime.Now;
    }

  }
}