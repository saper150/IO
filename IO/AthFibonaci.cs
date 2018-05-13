using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO {
    static class AthFibonaci {

        public static IEnumerable<long> Fibonaci() {
            long minusTwo = 0;
            long minusOne = 1;
            while (true) {
                yield return minusTwo;
                long tmp = minusOne;
                minusOne = minusTwo + minusOne;
                minusTwo = tmp;
            }
        }
    }
}
