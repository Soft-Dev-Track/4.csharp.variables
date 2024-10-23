namespace TestVariables
{
    public class Tests
    {
        [Test]
        public void TestHello()
        {
            Assert.That(Variables.Solution.SayHello("John"), Is.EqualTo("Hello John"));
        }
    }
}