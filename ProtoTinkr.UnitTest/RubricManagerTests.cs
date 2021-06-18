using System;
using NUnit.Framework;
using ProtoTinkr;

namespace ProtoTinkrTest
{
    [TestFixture]
    public class RubricManagerTests
    {
        [Test]
        public void ChangeRequirementPercentage_IsValidNumber_IsTrue()
        {
            var rubricManager = new RubricManager();
            var rubrica = new Rubrica();
            var newReq = new Random().Next(1,100);
            
            rubrica._exigencia = rubricManager.ChangeRequirementPercentage(newReq);
            Assert.IsTrue(rubrica._exigencia.Equals(newReq));
        }
        
        [Test]
        public void ChangeRequirementPercentage_IsNotValidNumber_IsExeption()
        {
            var rubricManager = new RubricManager();
            var rubrica = new Rubrica();
            var newReq = 0;
            
            rubrica._exigencia = rubricManager.ChangeRequirementPercentage(newReq);
        }
        
    }
}