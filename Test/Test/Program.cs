using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(1);//Тестируем круг
            double s = c.Area();
            Console.WriteLine("Круг с радиусом 1 имеет площадь " + s);
          
            Rectangle r = new Rectangle(2, 6);//Тестируем прямоугольник
            double p = r.Area();
            Console.WriteLine("Площадь прямоугольника = " + p);

            Sphere sp = new Sphere(3);
            double pl = sp.Area();
            Console.WriteLine("Площадь сферы = " + pl);

            Group g = new Group();//Находим сумму площади прямоугольника и круга
            g.AddEl(c);
            g.AddEl(r);
            double sum = g.Area();
            Console.WriteLine("Сумма площадей 2-х фигур = " + sum);
            

            Group gr = new Group();//Добавляем 1-ю группу во 2-ю группу
            gr.AddEl(g);
            gr.AddEl(sp);
            double summa=gr.Area();
            Console.WriteLine("Сумма площадей из 1-й группы  и сферы = " + summa);
            Console.ReadLine();
        }
    }


}
