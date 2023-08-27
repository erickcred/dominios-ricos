using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.ValueObjects
{
  [TestClass]
  public class DocumentTests
  {
    // Red, Green, Refector

    [TestMethod]
    public void ShouldReturnErrorWhenCNPJIsInvalid()
    {
      var document = new Document("123", EDocumentType.CNPJ);
      Assert.IsTrue(!document.IsValid);
    }

    [TestMethod]
    public void ShouldReturnSuccessWhenCNPJIsValid()
    {
      var document = new Document("12345678901234", EDocumentType.CNPJ);
      Assert.IsTrue(document.IsValid);
    }

    [TestMethod]
    public void ShouldReturnErrorWhenCPFIsInvalid()
    {
      var document = new Document("1234", EDocumentType.CPF);
      Assert.IsTrue(!document.IsValid);
    }

    [TestMethod]
    public void ShouldReturnSuccessWhenCPFIsValid()
    {
      var document = new Document("12312311231", EDocumentType.CPF);
      Assert.IsTrue(document.IsValid);
    }

  }
}