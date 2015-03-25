using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    /// <summary>
    /// Класс Группа, объединяющий фигуры
    /// </summary>
    class Group:Figure
    {
        List<Figure> listF = new List<Figure>();
        /// <summary>
        /// Находим сумму площадей
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            double sum = 0;
            for (int i = 0; i < listF.Count; i++)
            {
                sum = listF[i].Area() + sum;
            }
            return (sum);
        }
        /// <summary>
        /// Функция для заполнения списка
        /// </summary>
        /// <param name="f"></param>
        public void AddEl(Figure f) 
        {
            listF.Add(f);
        }

    }
}
