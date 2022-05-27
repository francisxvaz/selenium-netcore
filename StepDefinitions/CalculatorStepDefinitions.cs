namespace aunity.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private int number1;
        private int number2;
        private int sum;

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            number1 = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            number2 = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            sum = number1 + number2;
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            sum.Should().Be(result);
        }
    }
}