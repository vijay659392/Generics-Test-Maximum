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
        
    }
}