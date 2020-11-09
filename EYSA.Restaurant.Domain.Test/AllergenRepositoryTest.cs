using Common.Domain.Entities;
using EYSA.Restaurant.Domain.Contracts;
using EYSA.Restaurant.Domain.Queries;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace EYSA.Restaurant.Domain.Test
{
    public class AllergenRepositoryTest
    {
        Mock<IAllergenRepository> _allergenRepoMock = new Mock<IAllergenRepository>();
        [SetUp]
        public void Setup()
        {
            _allergenRepoMock.Setup(xx => xx.FindAllergen(new FindAllergenSpecification(It.IsAny<int>()))).Returns(Task.FromResult(MockedAllergen()));
        }

        [Test]
        public void FindAllergen()
        {
            Assert.IsNotNull(_allergenRepoMock.Object.FindAllergen(new FindAllergenSpecification(1)));
        }

        private Allergen MockedAllergen()
        {
            return new Allergen
            {
                Id = 1,
                Name = "testAllergen"
            };
        }
    }
}