using System.Collections.Generic;
using NUnit.Framework;

namespace Fizzbuzz.Test
{
    public class FizzBuzzTests
    {
        public Fizzbuzz FizzBuzz_3_5 => new Fizzbuzz(new SortedList<int, string> {{3, "fizz"}, {5, "buzz"}});
        public Fizzbuzz WibbleWobbleWoo_2_3_5 => new Fizzbuzz(new SortedList<int, string> {{2, "wibble"}, {3, "wobble"}, {5, "woo"}});

        [TestCase(1, ExpectedResult = "1")]
        [TestCase(3, ExpectedResult = "fizz")]
        [TestCase(5, ExpectedResult = "buzz")]
        [TestCase(15, ExpectedResult = "fizzbuzz")]
        [TestCase(8, ExpectedResult = "8")]
        [TestCase(18, ExpectedResult = "fizz")]
        [TestCase(20, ExpectedResult = "buzz")]
        [TestCase(30, ExpectedResult = "fizzbuzz")]
        public string Entry_ForFizzbuzz_ReturnsCorrectEntry(int n)
        {
            var fizzbuzz = FizzBuzz_3_5;

            var result = fizzbuzz.Entry(n);

            return result;
        }

        [TestCase(3, ExpectedResult = "foo")]
        [TestCase(6, ExpectedResult = "foobar")]
        public string Entry_WithMultiplesInRules_ReturnsCorrectEntry(int n)
        {
            var fizzbuzz = new Fizzbuzz(new SortedList<int, string> {{3, "foo"}, {6, "bar"}});

            var result = fizzbuzz.Entry(n);

            return result;
        }

        [Test]
        public void Sequence_ForFizzbuzz_ReturnsAllCorrectEntries()
        {
            var fizzbuzz = FizzBuzz_3_5;

            var result = fizzbuzz.Sequence(15);
            var expected = new List<string> {
                "1", "2", "fizz", "4", "buzz",
                "fizz", "7", "8", "fizz", "buzz",
                "11", "fizz", "13", "14", "fizzbuzz"
            };

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Sequence_ForWibbleWobbleWoo_ReturnsAllCorrectEntries()
        {
            var www = WibbleWobbleWoo_2_3_5;

            var result = www.Sequence(30);
            var expected = new List<string> {
                "1", "wibble", "wobble", "wibble", "woo",
                "wibblewobble", "7", "wibble", "wobble", "wibblewoo",
                "11", "wibblewobble", "13", "wibble", "wobblewoo",
                "wibble", "17", "wibblewobble", "19", "wibblewoo",
                "wobble", "wibble", "23", "wibblewobble", "woo",
                "wibble", "wobble", "wibble", "29", "wibblewobblewoo"
            };

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}