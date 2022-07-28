using WordCounter.Pages;

namespace WordCounter.Tests
{
    public class RenderTests : TestContext
    {
        [Fact]
        public void CounterComponentRendersCorrectly()
        {
            // Arrange
            var renderedComponent = RenderComponent<Counter>();
            var pElement = renderedComponent.Find("p");

            // Act
            var pElementText = pElement.TextContent;

            // Assert
            pElementText.MarkupMatches("Current count: 0");
        }

        [Fact]
        public void ErrorRendersCorrectly()
        {
            // Arrange
            var renderedComponent = RenderComponent<Counter>();
            var form = renderedComponent.Find("form");

            // Act
            form.Submit(); // textArea is empty first time when the form is submitted
            var validationMessage = renderedComponent.Find("li[class=validation-message]").TextContent;

            // Assert
            validationMessage.Contains("required");
        }
    }
}
