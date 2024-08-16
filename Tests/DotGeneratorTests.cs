using LifeDots_App.Services;
using LifeDots_App.Interfaces;
using Moq;
using Microsoft.AspNetCore.Components;

namespace LifeDots_App.Tests.Services
{
    public class DotGeneratorTests
    {
        [Fact]
        public void GenerateDots_ReturnsCorrectNumberOfDots()
        {
            // Arrange: Set up a mock for IDotColorizer and an instance of DotGenerator.
            var mockDotColorizer = new Mock<IDotColorizer>();
            mockDotColorizer.Setup(m => m.ColorDots(It.IsAny<string>())).Returns((string input) => input);
            var dotGenerator = new DotGenerator(mockDotColorizer.Object);
            int weeksToDie = 3;

            // Act: Call the GenerateDots method.
            string result = dotGenerator.GenerateDots(weeksToDie);

            // Assert: Verify that the result contains the correct number of dots (3 dots, each followed by a space).
            string expected = ". . . ";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GenerateDots_CallsColorDotsMethod()
        {
            // Arrange: Set up a mock for IDotColorizer and an instance of DotGenerator.
            var mockDotColorizer = new Mock<IDotColorizer>();
            mockDotColorizer.Setup(m => m.ColorDots(It.IsAny<string>())).Returns(string.Empty);
            var dotGenerator = new DotGenerator(mockDotColorizer.Object);
            int weeksToDie = 5;

            // Act: Call the GenerateDots method.
            dotGenerator.GenerateDots(weeksToDie);

            // Assert: Verify that the ColorDots method was called exactly once with the correct input.
            mockDotColorizer.Verify(m => m.ColorDots(". . . . . "), Times.Once);
        }

        [Fact]
        public void UpdateDotsDisplay_ReturnsMarkupStringWithCorrectDots()
        {
            // Arrange: Set up a mock for IDotColorizer and an instance of DotGenerator.
            var mockDotColorizer = new Mock<IDotColorizer>();
            mockDotColorizer.Setup(m => m.ColorDots(It.IsAny<string>())).Returns(". . . ");
            var dotGenerator = new DotGenerator(mockDotColorizer.Object);
            int weeksToDie = 3;

            // Act: Call the UpdateDotsDisplay method.
            MarkupString result = dotGenerator.UpdateDotsDisplay(weeksToDie);

            // Assert: Verify that the result is a MarkupString with the correct HTML content.
            MarkupString expected = new(". . . ");
            Assert.Equal(expected, result);
        }
    }
}