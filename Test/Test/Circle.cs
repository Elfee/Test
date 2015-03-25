using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    /// <summary>
    /// Класс Круг
    /// </summary>
    class Circle:Figure
    {
        double radius;
        /// <summary>
        /// Конструктор класса Круг
        /// </summary>
        /// <param name="r"></param>
        public Circle(double r)
        {
            radius = r;
        }
        /// <summary>
        /// Площадь
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            double s = radius * radius * Math.PI;
            return (s);
        }
    }
}
