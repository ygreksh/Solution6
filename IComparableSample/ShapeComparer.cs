using System.Collections.Generic;

namespace IComparableSample
{
    public class ShapeComparer : IComparer<SomeShape>
    {
        public int Compare(SomeShape x, SomeShape y)
        {
            return (int)(y.Square - x.Square);  //Грубое стравнение, но для наглядности годится. Сортировка будет по убыванию
        }
    }
}