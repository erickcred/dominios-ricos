using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
  public class Student : Entity
  {
    public Name Name { get; private set; }
    public Document Document { get; private set; }
    public Email Email { get; private set; }
    public Address Address { get; private set; }
    public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

    private IList<Subscription> _subscriptions { get; set; }

    public Student(Name name, Document document, Email email)
    {
      Name = name;
      Document = document;
      Email = email;
      _subscriptions = new List<Subscription>();
    }

    public void AddSubscription(Subscription subscription)
    {
      // Se já tiver uma assinatura ativa, cancela

      // Cancela todas as outras assinaturas e coloca esta como principal
      foreach(var sub in this.Subscriptions)
        sub.Activate(false);

      _subscriptions.Add(subscription);
    }


  }
}