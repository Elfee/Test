using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    /// <summary>
    /// Суперкласс всех фигур
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Мера, считающая площадь
        /// </summary>
        /// <returns></returns>
        public abstract double Area();
    } 
}
