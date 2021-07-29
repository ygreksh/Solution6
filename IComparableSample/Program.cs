using System;
using System.Collections.Generic;

namespace IComparableSample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SomeShape[] shapes = new SomeShape[]
            {
                new SomeShape {Name = "Круг", Square = 10},
                new SomeShape {Name = "Треугольник", Square = 12},
                new SomeShape {Name = "Квадрат", Square = 1},
                new SomeShape {Name = "Большой квадрат", Square = 100},
                new SomeShape {Name = "Трапеция", Square = 69},
                new SomeShape {Name = "Прямоугольник", Square = 33},
                new SomeShape {Name = "Эллипс", Square = 55},
                new SomeShape {Name = "Ромб", Square = 98},
                new SomeShape {Name = "Прямоугольный треугольник", Square = 74},
                new SomeShape {Name = "Параллелограмм", Square = 66},
            };

            //сортировка по убыванию и вывод
            Console.WriteLine("Сортировка по возрастанию и реверс используя Array");
            Array.Sort(shapes);
            Array.Reverse(shapes);
            foreach (var itemShape in shapes)
            {
                Console.WriteLine(itemShape.Name + " " + itemShape.Square);
            }
            
            //Использование IComparer
            Console.WriteLine("__________________________");
            Console.WriteLine("Сортировка по yбыванию при помощи ICompare");
            Array.Sort(shapes);                     //Сначала отсортируем по возрастанию       
            Array.Sort(shapes, new ShapeComparer());//тут сортируем по нашему  методу Compare
            foreach (var itemShape in shapes)
            {
                Console.WriteLine(itemShape.Name + " " + itemShape.Square);
            }
        }
    }
}