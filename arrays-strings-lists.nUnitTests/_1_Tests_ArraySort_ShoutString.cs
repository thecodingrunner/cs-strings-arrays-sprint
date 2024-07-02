using cs_arrays_strings_lists;

namespace arrays_strings_lists.nUnitTests
{
    [TestFixture]
    public class _1_Section1_Tests
    {
        [Test]
        public void ArraySort()
        {
            int[] input = { 30, 40, 1, 2, 9, 24 };
            int[] expected = { 1, 2, 9, 24, 30, 40 };
            int[] result = Task1.ArraySort(input);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void ShoutString()
        {
            string input = "Hello everyone here at Northcoders";
            string result = Task1.ShoutString(input);
            Assert.That(result, Is.EqualTo("HELLO EVERYONE HERE AT NORTHCODERS"));
        }
    }
}