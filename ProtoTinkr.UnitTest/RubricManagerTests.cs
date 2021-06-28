using System;
using NUnit.Framework;
using ProtoTinkr;

namespace ProtoTinkrTest
{
    [TestFixture]
    public class RubricManagerTests
    {
        private RubricManager _rubricManager;
        [SetUp]
        public void SetUp()
        {
            _rubricManager = new RubricManager();
        }
        
        [Test]
        public void ChangeRequirementPercentage_IsValidNumber_IsTrue()
        {
            var rubrica = new Rubrica();
            var newReq = new Random().Next(1,100);
            
            _rubricManager.ChangeRequirementPercentage(rubrica, newReq);
            Assert.IsFalse((rubrica._exigencia.Equals(0)));            
            Assert.IsTrue(rubrica._exigencia.Equals(newReq));
        }
        
        [Test]
        public void ChangeRequirementPercentage_IsZeroOrGreaterThanHundred_GeneratesException()
        {
            var rubrica = new Rubrica();
            rubrica._exigencia = 0;
            var newReq = 0;
            Assert.That(() => _rubricManager.ChangeRequirementPercentage(rubrica, newReq), Throws.ArgumentException);
        }
    }
}