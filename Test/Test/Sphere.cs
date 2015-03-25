using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    /// <summary>
    /// Класс Сфера
    /// </summary>
    class Sphere:Figure
    {
        double radius;
        /// <summary>
        /// Конструктор Сферы
        /// </summary>
        /// <param name="r"></param>
        public Sphere(double r) 
        {
            radius = r;
        }
        /// <summary>
        /// Площадь Сферы
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            double s = 4 * Math.PI * radius * radius;
            return (s);
        }
    }
}
