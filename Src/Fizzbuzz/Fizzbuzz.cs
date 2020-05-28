using System.Collections.Generic;
using System.Linq;

namespace Fizzbuzz
{
    public static class Fizzbuzz
    {
        /// <summary>
        /// Returns the fizzbuzz output for the n'th entry.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string Entry(int n) {
            if (n % 15 == 0) return "fizzbuzz";
            if (n % 5 == 0) return "buzz";
            if (n % 3 == 0) return "fizz";

            return n.ToString();
        }

        /// <summary>
        /// Returns an IEnumerably of entries from 1 up to and including n.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static IEnumerable<string> Sequence(int n) {
            return Enumerable.Range(1, n).Select(Fizzbuzz.Entry);
        }
    }
}