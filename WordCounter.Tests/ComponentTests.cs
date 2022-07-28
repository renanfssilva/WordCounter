using WordCounter.Pages;
using WordCounter.Tests.Utils;

namespace WordCounter.Tests
{
    public class ComponentTests : TestContext
    {
        [Fact]
        public void CounterShouldUpdateWhenFormSubmitted()
        {
            // Arrange
            var renderedComponent = RenderComponent<Counter>();
            var pElement = renderedComponent.Find("p");
            var textAreaElement = renderedComponent.Find("textarea");

            // Act
            textAreaElement.Change("naruto");
            renderedComponent.Find("form").Submit();
            var pElementText = pElement.TextContent;

            // Assert
            pElementText.MarkupMatches("Words counted: 1");
        }

        [Fact]
        public void CounterShouldBeZeroIfOnlyNumbersAreInserted()
        {
            // Arrange
            var renderedComponent = RenderComponent<Counter>();
            var pElement = renderedComponent.Find("p");
            var textAreaElement = renderedComponent.Find("textarea");

            // Act
            textAreaElement.Change("99999999999");
            renderedComponent.Find("form").Submit();
            var pElementText = pElement.TextContent;

            // Assert
            pElementText.MarkupMatches("Words counted: 0");
        }

        [Fact]
        public void CounterShouldBeZeroIfOnlySpecialCharactersAreInserted()
        {
            // Arrange
            var renderedComponent = RenderComponent<Counter>();
            var pElement = renderedComponent.Find("p");
            var textAreaElement = renderedComponent.Find("textarea");

            // Act
            textAreaElement.Change("~`!@#$%^&*()-_=+[]\\;',./{}|:\">?");
            renderedComponent.Find("form").Submit();
            var pElementText = pElement.TextContent;

            // Assert
            pElementText.MarkupMatches("Words counted: 0");
        }

        [Fact]
        public void CounterShouldCountCorrectlyWhenAreLeadingAndTrailingWhiteSpaces()
        {
            // Arrange
            var renderedComponent = RenderComponent<Counter>();
            var pElement = renderedComponent.Find("p");
            var textAreaElement = renderedComponent.Find("textarea");

            // Act
            textAreaElement.Change(" naruto ");
            renderedComponent.Find("form").Submit();
            var pElementText = pElement.TextContent;

            // Assert
            pElementText.MarkupMatches("Words counted: 1");
        }

        [Theory]
        [MemberData(nameof(TestData.Separators), MemberType = typeof(TestData))]
        public void CounterShouldCountCorrectlyWhenWordsAreSeparatedWithAnythingButLetter(string separator)
        {
            // Arrange
            var renderedComponent = RenderComponent<Counter>();
            var pElement = renderedComponent.Find("p");
            var textAreaElement = renderedComponent.Find("textarea");

            // Act
            textAreaElement.Change("naruto" + separator + "sasuke");
            renderedComponent.Find("form").Submit();
            var pElementText = pElement.TextContent;

            // Assert
            pElementText.MarkupMatches("Words counted: 2");
        }

        [Theory]
        [MemberData(nameof(TestData.AnotherAlphabetAndSeparators), MemberType = typeof(TestData))]
        public void CounterShouldCountCorrectlyRegardlessOfAlphabet(string naruto, string separator, string sasuke)
        {
            // Arrange
            var renderedComponent = RenderComponent<Counter>();
            var pElement = renderedComponent.Find("p");
            var textAreaElement = renderedComponent.Find("textarea");

            // Act
            textAreaElement.Change(naruto + separator + sasuke);
            renderedComponent.Find("form").Submit();
            var pElementText = pElement.TextContent;

            // Assert
            pElementText.MarkupMatches("Words counted: 2");
        }
    }
}
