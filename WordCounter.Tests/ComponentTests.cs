using WordCounter.Pages;

namespace WordCounter.Tests
{
    public class ComponentTests : TestContext
    {
        [Fact]
        public void CounterShouldBeZeroIfOnlyNumbersAreInserted()
        {
            // Arrange
            var renderedComponent = RenderComponent<Counter>();
            var pElement = renderedComponent.Find("p");
            var inputElement = renderedComponent.Find("textarea");

            // Act
            inputElement.Change("99999999999");
            renderedComponent.Find("form").Submit();
            var pElementText = pElement.TextContent;

            // Assert
            pElementText.MarkupMatches("Current count: 0");
        }
    }
}
