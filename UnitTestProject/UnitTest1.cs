using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void FindFourPrimesFun()
        {
            int[] expected = new[] { 313, 563, 811, 863 };
            int[] actual = GetPrime.Program.FindFourPrimes(1000);
            for (var i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void IsSeqIntFun()
        {
            Assert.IsTrue(GetPrime.Program.IsSeqInt(111234444567));
            Assert.IsFalse(GetPrime.Program.IsSeqInt(119234444566));
            Assert.IsFalse(GetPrime.Program.IsSeqInt(111234444568));

        }

        [TestMethod]
        public void PrimesFun()
        {
            List<int> expected = new List<int>();
            expected.Add(2);
            expected.Add(3);
            expected.Add(5);
            expected.Add(7);

            List<int> actual = GetPrime.Program.Primes(10);

            for (var i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }

        }
    }
}
