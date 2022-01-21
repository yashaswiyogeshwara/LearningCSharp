using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class EnumerableAndEnumerator
    {
        private  List<IEnumerator> GetEnumerators()
        {
            List<IEnumerator> enumerators = new List<IEnumerator>();
            int[] arr = { 1, 2, 3, 4, 5 };
            enumerators.Add(arr.GetEnumerator());
            List<int> list = new List<int>() { 6, 7, 8, 9, 10 };
            enumerators.Add(list.GetEnumerator());
            Dictionary<int, int> dictionary = new Dictionary<int, int>() { { 11, 11 }, { 12, 12 }, { 13, 13 }, { 14, 14 } };
            enumerators.Add(dictionary.GetEnumerator());
            Stack<int> stack = new Stack<int>();
            stack.Push(15);
            stack.Push(16);
            enumerators.Add(stack.GetEnumerator());
            Queue queue = new Queue();
            queue.Enqueue(17);
            queue.Enqueue(18);
            enumerators.Add(queue.GetEnumerator());
            return enumerators;
        }

        public void Enumerate()
        {
            List<IEnumerator> enumerators = GetEnumerators();
            foreach (IEnumerator e in enumerators)
            {
                while (e.MoveNext())
                {
                    Console.WriteLine(e.Current);
                }
            }
            Console.WriteLine("------------------------------------------");
        }
    }
}
