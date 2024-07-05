using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MindBoxLibrary.Tests
{
    /// <summary>
    /// Тесты для круга
    /// </summary>
    [TestClass]
    public class CircleTests
    {
        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        [TestMethod]
        public void AreaOfCircle()
        {
            //Arrenge
            Circle c = new(25);
            double expected = 1963.4954084936207d;

            //Act
            double actual = c.Area();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Тест на создание круга с отрицательным радиусом
        /// </summary>
        [TestMethod]
        public void NegativeCircle()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-1));
        }

        /// <summary>
        /// Тест на создание круга c радиусом равным 0
        /// </summary>
        [TestMethod]
        public void ZeroCircle()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(0));
        }

    }
}
