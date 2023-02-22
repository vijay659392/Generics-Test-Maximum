using FindMaxGeneric;

namespace FindMaxGenericTests
{
    public class Tests
    {
        FindMaxGeneric<int> genericMethodForInt = new FindMaxGeneric<int>();
        FindMaxGeneric<double> genericMethodForDouble = new FindMaxGeneric<double>();
        FindMaxGeneric<string> genericMethodForString = new FindMaxGeneric<string>();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = genericMethodForInt.FindValue(26, 30, 32);
            Assert.AreEqual(26, result);
            //Assert.Pass();
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = genericMethodForInt.FindValue(26, 30, 32);
            Assert.AreEqual(30, result);
            //Assert.Pass();
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = genericMethodForInt.FindValue(26, 30, 32);
            Assert.AreEqual(32, result);
            //Assert.Pass();
        }
        [Test]
        public void GivenMaxFloatNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            double result = genericMethodForDouble.FindValue(26.22f, 20.33f, 22.55f);
            Assert.AreEqual(26.22f, result);
            //Assert.Pass();
        }
        [Test]
        public void GivenMaxFloatNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            double result = genericMethodForDouble.FindValue(16.22f, 20.33f, 12.55f);
            Assert.AreEqual(20.33f, result);
            //Assert.Pass();
        }
        [Test]
        public void GivenMaxFloatNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            double result = genericMethodForDouble.FindValue(16.22f, 20.33f, 22.55f);
            Assert.AreEqual(22.55f, result);
            //Assert.Pass();
        }
    }
}