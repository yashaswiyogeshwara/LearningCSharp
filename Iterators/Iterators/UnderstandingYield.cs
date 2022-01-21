using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    class UnderstandingYield
    {
        public void Execute() {
            UnderstandingYield uy = new UnderstandingYield();
            IEnumerator enu1 = uy.YieldNumber();

            while (enu1.MoveNext())
            {
                Console.WriteLine(enu1.Current);
            }
        }
        public IEnumerator YieldNumber()
        {
            // Add break points for the below statements.
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
        }
    }
}
