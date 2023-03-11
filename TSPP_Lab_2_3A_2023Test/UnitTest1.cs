using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TSPP_Lab_2_3A_2023Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] B = { 0, -2, -6, -1, 5, 6, 8, -5 };
            int sum = TSPP_Lab_2_3A_2023.Program.ArgSumMines(B);
            Assert.AreEqual(-14, sum);
        }
        public void TestMethod2()
        {
            int[] B = { 0, -2, -6, -1, 5, 6, 8, -5 };
            int dob = TSPP_Lab_2_3A_2023.Program.ArgDobMinOrMax(B);
            Assert.AreEqual(-30, dob);
        }

    }
}
