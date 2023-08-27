using Flunt.Validations;
using Microsoft.VisualBasic;
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

      AddNotifications(name, document, email);      
    }

    public void AddSubscription(Subscription subscription)
    {
      var hasSubscriptionActive = false;

      foreach(var sub in _subscriptions)
      {
        if (sub.Active)
          hasSubscriptionActive = true;
      }

      // AddNotifications(new Contract<string>()
      //   .Requires()
      //   .IsFalse(hasSubscriptionActive, "Student.Subscriptions", "Você já tem uma assinatura ativa!")
      // );

      // Anternativa
      if (hasSubscriptionActive)
        AddNotification("Student.Subscriptions", "Você já tem uma assinatura ativa!");
    }


  }
}