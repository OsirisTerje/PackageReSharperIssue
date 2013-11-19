using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace PackageResharperIssue
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void AddRandom()
        {
            var gen = new Mock<IRandom>();
            gen.Setup(f => f.GenerateRandomNumber()).Returns(42);

            var result = gen.Object.GenerateRandomNumber();
            Assert.That(result,Is.EqualTo(42));
        }
    }
}
