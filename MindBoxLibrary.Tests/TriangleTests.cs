using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MindBoxLibrary.Tests
{
    /// <summary>
    /// Тесты для треугольника
    /// </summary>
    [TestClass]
    public class TriangleTests
    {
        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        [TestMethod]
        public void AreaOfTriangle()
        {
            //Arrenge
            Triangle triangle = new(3, 4, 5);
            double expected = 6d;

            //Act
            double actual = triangle.Area();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест прямоугольного треугольника
        /// </summary>
        [TestMethod]
        public void IsRectangular()
        {
            //Arrenge
            Triangle c = new(3, 4, 5);
            bool expected = true;

            //Act
            bool actual = c.IsRectangular();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Тест не прямоугольного треугольника на прямоугольный 
        /// </summary>
        [TestMethod]
        public void IsNotRectangular()
        {
            //Arrenge
            Triangle c = new(2, 4, 5);
            bool expected = false;

            //Act
            bool actual = c.IsRectangular();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест на создание треугольника с отрицательными сторонами
        /// </summary>
        [TestMethod]
        public void NegativeTriangle()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-1, -1, -1));
        }

        /// <summary>
        /// Тест на создание треугольника из нулевых отрезков 
        /// </summary>
        [TestMethod]
        public void ZeroTriangle()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(0, 0, 0));
        }

        /// <summary>
        /// Тест на создание треугольника из которых невозможно сделать треугольник
        /// </summary>
        [TestMethod]
        public void NotTriangle()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(30, 1, 1));
        }
    }
}
