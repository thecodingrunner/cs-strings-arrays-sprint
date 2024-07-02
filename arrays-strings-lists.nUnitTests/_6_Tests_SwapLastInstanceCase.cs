using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs_arrays_strings_lists;

namespace arrays_strings_lists.nUnitTests
{
    [TestFixture]
    [Ignore("Section 3 SwapLastInstanceCase skipped")] //Delete this line to run code for SwapLastInstanceCase
    public class _6_SwapLastInstanceCase
    {
        [Test]
        public static void SwapLastInstanceCase_OneInstance()
        {
            string[] input = { "These", "yellow", "cars", "are", "great", "yellow", "cars" };
            string expected = "These yellow cars are great YELLOW cars";
            var result = Task6.SwapLastInstanceCase(input);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public static void SwapLastInstanceCase_MultipleInstances()
        {
            string[] input = { "I", "LOVE", "CROWS", "BECAUSE", "CROWS", "ARE", "GREAT" };
            string expected = "I LOVE CROWS BECAUSE crows ARE GREAT";
            var result = Task6.SwapLastInstanceCase(input);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
