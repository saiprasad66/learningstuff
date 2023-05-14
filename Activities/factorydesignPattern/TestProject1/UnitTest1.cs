using factorydesignPattern.Controllers;

namespace TestProject1
{
    public class UnitTest1
    {
        //[Fact]
        [Theory]
        [InlineData(1,"sai")]
        [InlineData(2,"Kaveri")]
        public void Test1(int id,string name)
        {
            //arrange -set up the environment for testing
            TestController tc = new TestController();

            //Act-Create the test case
            string result=tc.check(id);
            //Assert -if the acutal output =expected output

            Assert.Equal(result,name);
        }
    }
}