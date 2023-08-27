using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
          var subscription = new Subscription(null);
          var student = new Student(new Name("João", "Silva"), new Document("12345678910", EDocumentType.CPF), new Email("joao@email.com"));
          student.AddSubscription(subscription);
          
          
        }
    }
}