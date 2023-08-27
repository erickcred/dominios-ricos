using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
          var subscription = new Subscription(null);
          var student = new Student("João", "Silva", "12345678910", "joao@email.com");
          student.AddSubscription(subscription);
          
          
        }
    }
}