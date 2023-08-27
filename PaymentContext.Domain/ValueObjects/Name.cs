using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
  public class Name : ValueObject
  {
    public Name(string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;
      

      if (firstName.Length <= 3) throw new Exception("Nome inválido!");
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }

  }
}