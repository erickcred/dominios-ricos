using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
  public class Address : ValueObject
  {
    public string Street { get; private set; }
    public string Number { get; private set; }
    public string Neighborhood { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string Country { get; private set; }
    public string ZipCode { get; private set; }

    public Address(
      string street,
      string number,
      string neighborhood,
      string city,
      string state,
      string country,
      string zipCode
    )
    {
      Street = street;
      Number = number;
      Neighborhood = neighborhood;
      City = city;
      State = state;
      Country = country;
      ZipCode = zipCode;

      AddNotifications(new Contract<string>()
        .Requires()
        .IsLowerThan(Street, 3, "Address.Street", "Street deve conter no minímo 3 caracteres!")
        .IsLowerThan(Number, 3, "Address.Number", "Number deve conter no minímo 3 caracteres!")
        .IsLowerThan(Neighborhood, 3, "Address.Neighborhood", "Neighborhood deve conter no minímo 3 caracteres!")
        .IsLowerThan(City, 3, "Address.City", "City deve conter no minímo 3 caracteres!")
        .IsLowerThan(State, 3, "Address.State", "State deve conter no minímo 3 caracteres!")
        .IsLowerThan(Country, 3, "Address.Country", "Country deve conter no minímo 3 caracteres!")
        .IsLowerThan(ZipCode, 3, "Address.ZipCode", "ZipCode deve conter no minímo 3 caracteres!")
      );
    }


  }
}