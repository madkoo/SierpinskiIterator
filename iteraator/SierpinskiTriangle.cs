using System.Collections;
using System.Collections.Generic;

namespace Iteraator
{
    public class SierpinskiTriangle :  IEnumerable<Point>
    {

        public List<Point> Elements;


        public void Append(Point element)
        {
            Elements.Add(element);
        }

        private Point _topPoint;
        private Point _leftPoint;
        private Point _rightPoint;
        private int _level;


        public SierpinskiTriangle(Point topPoint, Point leftPoint, Point rightPoint, int level)
        {
            _topPoint = topPoint;
            _leftPoint = leftPoint;
            _rightPoint = rightPoint;
            _level = level;
            Elements = new List<Point>();
        }



        private Point CalculateMidPoint(Point p1, Point p2)
        {
            var x = (p1.X() + p2.X()) / 2f;
            var y = (p1.Y() + p2.Y()) / 2f;
            var result = new Point(x, y);
            return result;
        }



        public IEnumerable<Point> SierpinskiTriangleIterator(Point topPoint, Point leftPoint, Point rightPoint, int level)
        {
            if (level == 0)
            {
                // Fill the triangle.
                Append(topPoint);
                Append(leftPoint);
                Append(rightPoint);
            }
            else
            {
                // Find the edge midpoints.
                var leftMid = CalculateMidPoint(topPoint, leftPoint);
                var rightMid = CalculateMidPoint(topPoint, rightPoint);
                var bottomMid = CalculateMidPoint(leftPoint, rightPoint);
                SierpinskiTriangleIterator(topPoint, leftMid, rightMid, level - 1);
                SierpinskiTriangleIterator(leftMid, leftPoint, bottomMid, level - 1);
                SierpinskiTriangleIterator(rightMid, bottomMid, rightPoint, level - 1);
            }
            return Elements;
            
        }

      

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return SierpinskiTriangleIterator(_topPoint, _leftPoint, _rightPoint, _level);
        }

        IEnumerator<Point> IEnumerable<Point>.GetEnumerator()
        {

            return SierpinskiTriangleIterator(_topPoint, _leftPoint, _rightPoint, _level).GetEnumerator();
        }
    }
}