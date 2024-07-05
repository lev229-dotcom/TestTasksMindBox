namespace MindBoxLibrary
{
    /// <summary>
    /// Класс, для работы с кругом
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        private readonly double r;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="r">Радиус круга</param>
        /// <exception cref="ArgumentException">данное исключение генерируется, 
        /// если в метод для параметра передается некорректное значение</exception>
        public Circle(double r)
        {
            if(r <= 0)
                throw new ArgumentException("Радиус может быть только положительным числом"); 
            
            this.r = r;
        }

        /// <summary>
        /// Метод, для вычисления площади круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        public override double Area()
        {
            return Math.PI * r * r;
        }
    }

}
