using System.Collections.Generic;

namespace gregslist
{
    public class myQueue<T>
    {
        private List<T> Elements { get; set; } = new List<T>();

        public void Add(T elem)
        {
            Elements.Add(elem);
        }

        public T Remove()
        {
            T elem = Elements[0];
            Elements.Remove(elem);
            return elem;
        }
    }

    public class Chores
    {
        public myQueue<string> ChoreNames { get; set; }

        public myQueue<decimal> Payouts { get; set; }
    }


}