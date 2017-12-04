using System.Collections;
using System.Collections.Generic;

namespace Iteraator
{
    public class ElementFactory
    {

        public IEnumerable<PointSimulationElement> AppendPlanets()
        {
           var planetarySystem = new PlanetarySystem<PointSimulationElement>();
            planetarySystem.Append(new Planet(5,0,0.0));
            planetarySystem.Append(new Planet(10,2,0.8));
            planetarySystem.Append(new Planet(20,15,0.5));
            return planetarySystem;
        }


        public IEnumerable<Point> AppendSierpinski(int level)
        {
            var topPoint = new Point();
            var leftPoint = new Point(40);
            var rightPoint = new Point(20, 30);
            var ps = new SierpinskiTriangle(topPoint, leftPoint, rightPoint, level);
            return ps;
        }

    }
}
