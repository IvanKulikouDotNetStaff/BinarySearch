namespace BinarySearchTests
{
    public class BinarySearchTests
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, ExpectedResult = 2)]
        [TestCase(new int[] { -3, -2, -1, 0, 1, 2, 3 }, -3, ExpectedResult = 0)]
        [TestCase(new int[] { -7, -3, 0, 4, 9, 22, 90 }, 22, ExpectedResult = 5)]
        public int HasIndexOfItemInSortedArray(int[] numArray, int item)
        {
            Search search = new();
            return search.BinarySearch(numArray, item);
        }

        [Test]
        [TestCase(null,8)]
        [TestCase(null,5)]
        [TestCase(null,2)]
        public void ThrowArgumentNullExceptionIfArrayIsNull(int[] numArray, int item)
        {
            Search search = new();
            Assert.Throws<ArgumentNullException>(() => search.BinarySearch(numArray, item));
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 8)]
        [TestCase(new int[] { -3, -2, -1, 0, 1, 2, 3 }, 5)]
        [TestCase(new int[] { -7, -3, 0, 4, 9, 22, 90 }, 2)]
        public void ThrowArgumentOutOfRangeException(int[] numArray, int item)
        {
            Search search = new();
            Assert.Throws<ArgumentOutOfRangeException>(() => search.BinarySearch(numArray, item));
        }
    }
}