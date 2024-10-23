namespace TestFundamentals
{
    public class TestVariables
    {
        [Test]
        public void Test_Hello()
        {
            Assert.That(Variables.Solution.Hello("John"), Is.EqualTo("Hello John"));
        }
    }
}
