using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Iterators
{
    public class Yield
    {
        public void ProcessYield() {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            IEnumerator enumerator = GetNumbers();
            while (enumerator.MoveNext() == true) {
                Console.WriteLine(enumerator.Current);
                if (sw.ElapsedMilliseconds == 3000) {
                    sw.Stop();
                    break;
                }
            }
        }

        private IEnumerator GetNumber() {
            yield return 1;
            yield return 2;
        }

        private IEnumerator GetNumbers() {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (true) {
                Random random = new Random(23);
                yield return random.Next();
                if (sw.ElapsedMilliseconds == 3000) {
                    sw.Stop();
                    break;
                }
            }
        }
    }
}
