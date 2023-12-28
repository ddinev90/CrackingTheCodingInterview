using ArraysAndStrings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStringsTests
{
    public class CheckPermutationTests
    {
        private CheckPermutation IsPermutation;
        [SetUp]
        public void Setup()
        {
            IsPermutation = new CheckPermutation();
        }

        [Test]
        public void CheckPermutationReturnsTrueIfStringsIdentical()
        {
            Assert.IsTrue(IsPermutation.IsPermutation("abcqwergz", "abcqwergz"));
        }
        [Test]
        public void CheckPermutationReturnsFalseIfStringsDifferent()
        {
            Assert.IsFalse(IsPermutation.IsPermutation("abcqwergz", "abcqwergx"));
        }
        [Test]
        public void CheckPermutationReturnsFalseIfStringsDifferentSize()
        {
            Assert.IsFalse(IsPermutation.IsPermutation("abcqwergz", "abcqwergxq"));
        }
    }
}
