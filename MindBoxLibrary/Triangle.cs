namespace MindBoxLibrary
{
    /// <summary>
    /// Класс, для работы с треугольником
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Стороны треугольника
        /// </summary>
        private readonly double a, b, c;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="a">Сторона треугольника</param>
        /// <param name="b">Сторона треугольника</param>
        /// <param name="c">Сторона треугольника</param>
        /// <exception cref="ArgumentException">данное исключение генерируется, 
        /// если в метод для параметра передается некорректное значение</exception>
        /// <exception cref="ArgumentOutOfRangeException">данное исключение генерируется, 
        /// если значение аргумента находится вне диапазона допустимых значений</exception>
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Стороны треугольника могут быть только положительными числами");
            if(a + b < c || a + c < b || b +c < a)
                throw new ArgumentOutOfRangeException("Данные отрезки не могут образовать треугольник");

            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Метод, для проверки, является ли треугольник прямоугольным
        /// </summary>
        /// <returns>true, если треугольник прямоугольный
        /// и false, если треугольник не прямоугольный</returns>
        public bool IsRectangular()
        {
            var SidesByAscending = new List<double> { a, b, c }.OrderBy(x => x);// Сортировка по возрастанию

            return Math.Round(Math.Pow(SidesByAscending.ElementAt(0), 2) 
                    + Math.Pow(SidesByAscending.ElementAt(1), 2))
                    == Math.Round(Math.Pow(SidesByAscending.ElementAt(2), 2));
        }

        /// <summary>
        /// Метод, для вычисления площади треугольника
        /// </summary>
        /// <returns>площадь треугольника</returns>
        public override double Area()
        {
            double HalfMeter = new List<double> { a, b, c }.Sum() / 2;// Подсчет полупериметра

            return Math.Sqrt(HalfMeter * (HalfMeter - a) * (HalfMeter - b) * (HalfMeter - c));
        }
    }
}
