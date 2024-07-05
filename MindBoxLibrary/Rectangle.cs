namespace MindBoxLibrary
{
    /// <summary>
    /// Класс, для работы с прямоугольником
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Стороны прямоугольника
        /// </summary>
        private readonly double a, b;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="a">Сторона прямоугольника</param>
        /// <param name="b">Сторона прямоугольника</param>
        /// <exception cref="ArgumentException">данное исключение генерируется, 
        /// если в метод для параметра передается некорректное значение</exception>

        public Rectangle(double a, double b)
        {
            if (a <= 0 || b <= 0 )
                throw new ArgumentException("Стороны прямоугольника могут быть только положительными числами");

            this.a = a;
            this.b = b;
        }

        /// <summary>
        /// Метод, для вычисления площади прямоугольника
        /// </summary>
        /// <returns>площадь прямоугольника</returns>
        public override double Area()
        {
            return a * b;
        }
    }
}
