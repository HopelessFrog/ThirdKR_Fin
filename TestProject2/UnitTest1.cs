
using ThirdKR;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] xstestt = new double[] {0,5,10};
            double[] ystestt = new double[] {1,26,101};
            DataHolder<double> data = new DataHolder<double>(0, 10, 5, 1);
            GraphData graphData = new GraphData(xstestt,ystestt);
            Calculator calculator = new Calculator();
            var test = calculator.GetGraphData(data);
            for (int i = 0; i < xstestt.Length; i++)
            {
                Assert.AreEqual(test.xs[i], graphData.xs[i]);
                Assert.AreEqual(test.ys[i], graphData.ys[i]);
            }
        }
    }
}