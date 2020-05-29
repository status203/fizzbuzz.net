using System.Collections.Generic;
using System.Linq;

namespace Fizzbuzz
{
    public class Fizzbuzz
    {
        /// <summary>
        /// How factors translate to strings.
        /// Multiple factors are appended (smallest -> largest)
        /// No specials rules for multiples in the rules, e.g. if multiples
        /// of 3 & 6 are to be translated, both strings are appended
        /// </summary>
        /// <value></value>
        private SortedList<int, string> Rules { get; set; }

        public Fizzbuzz(SortedList<int, string> rules)
        {
            // Take a copy so they can't be changed under us.
            Rules = new SortedList<int, string>(rules);
        }

        /// <summary>
        /// Returns whether m is exactly divisible by n.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        private bool IsDivisable(int m, int n) => (m % n == 0);

        /// <summary>
        /// Returns the fizzbuzz output for the n'th entry.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string Entry(int n)
        {
            // Assume there won't be sufficient rules to make a builder worthwhile.
            var replacement = "";
            foreach(var kvp in Rules) {
                if (IsDivisable(n, kvp.Key)) {
                    replacement += kvp.Value;
                }
            }
            return replacement == "" ? n.ToString() : replacement;
        }

        /// <summary>
        /// Returns an IEnumerably of entries from 1 up to and including n.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public IEnumerable<string> Sequence(int n)
        {
            return Enumerable.Range(1, n).Select(Entry);
        }
    }
}