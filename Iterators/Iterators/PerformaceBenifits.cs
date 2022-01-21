using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class PerformaceBenifits
    {   
        private bool DivideBy2(int x) 
        {
            if (x % 2 == 0)
            {
                return true;
            }
            else {
                return false;
            }
        }

        private bool DivideBy3(int x)
        {
            if (x % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Execute(){
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<int> multiplesOfSix =
                (numbers.FilterWithOutYield(DivideBy2)
                .FilterWithOutYield(DivideBy3)) as List<int>;

            IEnumerable<int> multiplesOfSixUsingYield =
                numbers.FilterWithYield(
                   DivideBy2
                    )
                .FilterWithYield(
                    DivideBy3
                    );

            foreach (int x in multiplesOfSixUsingYield) {
                Console.WriteLine(x);
            }
        }

    }

    public static class Extensions {
        public static IEnumerable<int> FilterWithOutYield(this IEnumerable<int> enumerable, Func<int, bool> func)
        {
            IEnumerator<int> enumerator = enumerable.GetEnumerator();
            List<int> result = new List<int>();
            while (enumerator.MoveNext())
            {
                if (func(enumerator.Current))
                {
                    result.Add(enumerator.Current);
                }
            }
            return result as IEnumerable<int>;
        }
        public static IEnumerable<int> FilterWithYield(this IEnumerable<int> enumerable, Func<int,bool> func)
        {
            IEnumerator<int> enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext()) {
                if (func(enumerator.Current))
                {
                    yield return enumerator.Current;
                }
            }
        }
    }
    
}
