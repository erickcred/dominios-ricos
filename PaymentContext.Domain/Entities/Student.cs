namespace PaymentContext.Domain.Entities
{
  public class Student
  {
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Document { get; private set; }
    public string Email { get; private set; }
    public string Address { get; private set; }
    public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

    private IList<Subscription> _subscriptions { get; set; }

    public Student(string firstName, string lastName, string document, string email)
    {
      FirstName = firstName;
      LastName = lastName;
      Document = document;
      Email = email;
      _subscriptions = new List<Subscription>();

      if (firstName.Length <= 3) throw new Exception("Nome inválido!");
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