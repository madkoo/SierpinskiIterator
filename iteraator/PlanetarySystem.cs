using System.Collections;
using System.Collections.Generic;

namespace Iteraator
{
    public class PlanetarySystem<T> : IEnumerable<T>, ISimulationElement where T : ISimulationElement
    {
        protected List<T> Elements;

        public PlanetarySystem()
        {
            Elements = new List<T>();
        }

        #region ISimulationElement Members

        public void Tick()
        {
            foreach (T e in Elements)
            {
                e.Tick();
            }
        }

        #endregion

        public void Append(T element)
        {
            Elements.Add(element);
        }

        public T GetElement(int indeks)
        {
            return Elements[indeks];
        }

        public int Size()
        {
            return Elements.Count;
        }


        public IEnumerator<T> GetEnumerator()
        {
            return Elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

       
    }
}