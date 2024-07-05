namespace MindBoxLibrary
{
    /// <summary>
    /// Абстрактный класс, от которого наследуются все фигуры
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Абстрактный метод, для вычисления площади фигур, который необходимо переопределить
        /// </summary>
        /// <returns>Площадь</returns>
        public abstract double Area();
    }
}
