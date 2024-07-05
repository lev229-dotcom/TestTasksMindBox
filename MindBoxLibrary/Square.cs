namespace MindBoxLibrary
{
    /// <summary>
    /// Класс, для работы с квадратом
    /// </summary>
    public class Square : Rectangle
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="a">Сторона квадрата</param>
        /// <exception cref="ArgumentException">данное исключение генерируется, 
        /// если в метод для параметра передается некорректное значение</exception>
        public Square(double a) : base(a, a)
        {
            if (a <= 0)
                throw new ArgumentException("Сторона квадрата может быть только положительным числом");
        }
    }
}
