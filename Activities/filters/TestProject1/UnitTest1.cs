using ClassLibrary1;

namespace TestProject1
{
    public class Tests
    {

        Class1  _class1= new Class1();
       
        [TestCase("123",true)]
        [TestCase("saiprasad",false)]
        [TestCase("sai",true)]
        
        [Test]
        public void Test1(string str,bool expected)
        {
            bool actual=_class1.valid(str);

            Assert.AreEqual(actual,expected);
        }
    }
}