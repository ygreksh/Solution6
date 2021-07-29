using System;

namespace IComparableSample
{
    //упрощенный класс произвольной геометрической фигуры
    public class SomeShape : IComparable
    {
        public string Name { get; set; }        //Название фигуры
        public double Square { get; set; }      //площадь
        
        
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            SomeShape otherShape = obj as SomeShape;
            /*
            if (otherShape != null)
                return this.Square - otherShape.Square;
                */
            if (otherShape != null)
                return this.Square.CompareTo(otherShape.Square);
            else
                throw new ArgumentException("Object is not a SomeShape");
        }
    }
}