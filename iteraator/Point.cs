using System;

namespace Iteraator
{
    public class Point
    {

        double _x, _y;

        public Point(double x = 0.0, double y = 0.0)
        {
            _x = x;
            _y = y;
        }


        public override string ToString()
        {
            return $" {X()} " +
                    $"y: {Y()}, " +
                    $"rho:  {Rho()}, " +
                    $"theta: {Theta()}";
        }

        #region Queries

        public double X()
        {
            //"Abscissa"
            return _x;
        }

        public double Y()
        {
            //"Ordinate"
            return _y;
        }

        public double Rho()
        {
            //"Distance to origin (0, 0)"
            return Math.Sqrt(Math.Pow(X(), 2) + Math.Pow(Y(), 2));
        }

        public double Theta()
        {
            //"Angle to horizontal axis
            return Math.Atan2(Y(), X());
        }


        public double Distance(Point other)
        {
            //"Distance to other"
            return VectorTo(other).Rho();
        }
        public Point VectorTo(Point other)
        {
            //"Returns the Point representing the vector from self to other Point"
            return new Point(other.X() - X(), other.Y() - Y());
        }


        #endregion

        #region Commands

        public void Translate(double dx, double dy)
        {
            //"Move by dx horizontally, dy vertically
            _x += dx;
            _y += dy;
        }
        public void Scale(double factor)
        {
            //"Scale by factor"
            _x *= factor;
            _y *= factor;
        }

        public void CentreRotate(double angle)
        {
            //"Rotate around origin (0, 0) by angle"
            var temp_x = Rho() * Math.Cos(Theta() + angle);
            var temp_y = Rho() * Math.Sin(Theta() + angle);
            _x = temp_x;
            _y = temp_y;
        }
        public void Rotate(Point p, double angle)
        {
            //"Rotate around p by angle"
            Translate(-p.X(), -p.Y());
            CentreRotate(angle);
            Translate(p.X(), p.Y());
        }


        #endregion

    }
}