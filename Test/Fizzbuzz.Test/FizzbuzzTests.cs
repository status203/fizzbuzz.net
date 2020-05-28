using System.Collections.Generic;
using NUnit.Framework;

namespace Fizzbuzz.Test
{
    public class FizzBuzzTests
    {
        [TestCase(1, ExpectedResult = "1")]
        [TestCase(3, ExpectedResult = "fizz")]
        [TestCase(5, ExpectedResult = "buzz")]
        [TestCase(15, ExpectedResult = "fizzbuzz")]
        [TestCase(8, ExpectedResult = "8")]
        [TestCase(18, ExpectedResult = "fizz")]
        [TestCase(20, ExpectedResult = "buzz")]
        [TestCase(30, ExpectedResult = "fizzbuzz")]
        public string Entry_Called_ReturnsCorrectEntry(int n)
        {
            var result = Fizzbuzz.Entry(n);

            return result;
        }

        [Test]
        public void Sequence_Called_ReturnsAllCorrectEntries()
        {
            var result = Fizzbuzz.Sequence(15);
            var expected = new List<string> {
                "1", "2", "fizz", "4", "buzz",
                "fizz", "7", "8", "fizz", "buzz",
                "11", "fizz", "13", "14", "fizzbuzz"
            };

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}