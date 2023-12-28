using ArraysAndStrings;

namespace ArraysAndStringsTests
{
    public class IsUniqueTests
    {
        private IsUnique isUnique;
        [SetUp]
        public void Setup()
        {
            isUnique = new IsUnique();
        }

        [Test]
        public void BruteForceCheckWillReturnTrue()
        {
            Assert.IsTrue(isUnique.UniqueCheckerBruteForce("abcqwergz"));
        }
        [Test]
        public void BruteForceCheckWillReturnFalse()
        {
            Assert.IsFalse(isUnique.UniqueCheckerBruteForce("abcqwergza"));
        }
        [Test]
        public void AdditionalStructureCheckWillReturnFalse()
        {
            Assert.IsFalse(isUnique.UniqueCheckerWithAdditionalStructure("abcqwergza"));
        }
        [Test]
        public void AdditionalStructureCheckWillReturnTrue()
        {
            Assert.IsTrue(isUnique.UniqueCheckerWithAdditionalStructure("abcqwergz"));
        }

        [Test]
        public void NoAdditionalStructureCheckWillReturnFalse()
        {
            Assert.IsFalse(isUnique.UniqueCheckWithoutAnyStructures("abcqwergza"));
        }
        [Test]
        public void NoAdditionalStructureCheckWillReturnTrue()
        {
            Assert.IsTrue(isUnique.UniqueCheckWithoutAnyStructures("abcqwergz"));
        }
    }
}