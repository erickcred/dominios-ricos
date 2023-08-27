using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Entities.Payments;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Entities
{
  [TestClass]
  public class StudentTests
  {
    private readonly Name _name;
    private readonly Document _document;
    private readonly Email _email;
    private readonly Student _student;
    private readonly Subscription _subscription;
    private readonly Address _address;
    private readonly Payment _payment;


    public StudentTests()
    {
      _name = new Name("Rodrigo", "Silva");
      _document = new Document("09812312312", EDocumentType.CPF);
      _email = new Email("rodrigo@email.com");
      _student = new Student(_name, _document, _email);
      _subscription = new Subscription(null);
      _address = new Address("Rua", "Número", "Bairro", "Gothan", "SP", "BR", "13400123");
    }

    [TestMethod]
    public void ShouldReturnErrorWhenActiveSubscription()
    {
      var payment = new PayPalPayment(DateTime.Now, DateTime.Now.AddMonths(12), 10, 10, "Lex Lutor", _document, _address, _email, "12312312312");
      _subscription.AddPayment(payment);

      _student.AddSubscription(_subscription);
      _student.AddSubscription(_subscription);

      // Assert.Fail();
      Assert.IsTrue(!_student.IsValid);
    }

    [TestMethod]
    public void ShouldReturnErrorWhenActiveSubscriptionHasNoPayment()
    {
      _student.AddSubscription(_subscription);

      // Assert.Fail();
      Assert.IsTrue(!_student.IsValid);
    }

    [TestMethod]
    public void ShouldReturnSuccessWhenAddSubscription()
    {
      var payment = new PayPalPayment(DateTime.Now, DateTime.Now.AddMonths(12), 10, 10, "Lex Lutor", _document, _address, _email, "12312312312");
      _subscription.AddPayment(payment);
      _student.AddSubscription(_subscription);

      // Assert.Fail();
      Assert.IsTrue(_student.IsValid);
    }
  }
}