using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
  public class Name : ValueObject
  {
    public Name(string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;

      AddNotifications(new Contract<string>()
        .Requires()
        .IsLowerThan(FirstName, 3, "Name.FirstName", "Nome deve conter no minímo 3 caracteres")
        .IsLowerThan(LastName, 3, "Name.LastName", "Sobrenome deve conter no minímo 3 caracteres")
      );      


      if (string.IsNullOrEmpty(FirstName)) AddNotification("FirstName", "Nome inválido!");
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }

  }
}