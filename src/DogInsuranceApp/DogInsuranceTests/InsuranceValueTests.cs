using DogInsuranceLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogInsuranceTests
{
    [TestFixture]
    public class InsuranceValueTests
    {
        [Test]
        public void BasicTest()
        {
            var policyData = InsuranceValue.GetInsuranceValue(6, 15, 60, 500, 4);
            Assert.NotNull(policyData.BasicInfo());
            Assert.AreEqual(36.34f, policyData.monthlyPayments[0]);
            Assert.AreEqual(7975.08f, policyData.totalPaid);
        }
    }
}
