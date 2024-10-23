namespace TestFundamentals
{
    public class TestVariables
    {
        [Test]
        public void Test_Hello()
        {
            Assert.That(Variables.Solution.Hello("John"), Is.EqualTo("Hello John"));
        }

        [Test]
        public void AgeToFloat()
        {
            Assert.That(Variables.Solution.AgeToFloat(23), Is.EqualTo(11.5f));
        }

        [Test]
        public void Test_CelciusToFarenheit()
        {
            Assert.That(Variables.Solution.CelciusToFarenheit(2), Is.EqualTo(35.6m));
        }

        [Test]
        public void Test_KilometersToMiles()
        {
            Assert.That(Variables.Solution.KilometersToMiles(2), Is.EqualTo(1.2));
        }
    }
}
