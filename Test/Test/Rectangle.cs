using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{

    /// <summary>
    /// класс Прямоугольник
    /// </summary>
    public class Rectangle : Figure
    {
        double length;
        double width;
        /// <summary>
        /// Конструктор прямоугольника
        /// </summary>
        /// <param name="l">-длина</param>
        /// <param name="w">-ширина</param>
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public override double Area()
        {
            double s = length * width;
            return (s);
        }
    }
}
