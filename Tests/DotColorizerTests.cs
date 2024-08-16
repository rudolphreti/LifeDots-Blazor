using LifeDots_App.Services;

namespace LifeDots_App.Tests.Services
{
    public class DotColorizerTests
    {
        [Fact]
        public void ColorDots_AlternatesColorsCorrectly()
        {
            // Arrange: Create an instance of DotColorizer and a string with a specific number of dots.
            var dotColorizer = new DotColorizer();
            string dotsHtml = "...."; // 4 dots should result in 4 differently colored spans

            // Act: Call the ColorDots method with the input string.
            string result = dotColorizer.ColorDots(dotsHtml);

            // Assert: Verify that the output contains the correct sequence of colored spans.
            string expectedOutput =
                "<span style='color: red'>. </span>" +
                "<span style='color: yellow'>. </span>" +
                "<span style='color: green'>. </span>" +
                "<span style='color: blue'>. </span>";

            Assert.Equal(expectedOutput, result);
        }

        [Fact]
        public void ColorDots_HandlesEmptyInput()
        {
            // Arrange: Create an instance of DotColorizer and an empty string as input.
            var dotColorizer = new DotColorizer();
            string dotsHtml = ""; // No dots

            // Act: Call the ColorDots method with the empty string.
            string result = dotColorizer.ColorDots(dotsHtml);

            // Assert: Verify that the output is also an empty string.
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void ColorDots_HandlesNonDotCharacters()
        {
            // Arrange: Create an instance of DotColorizer and a string with non-dot characters.
            var dotColorizer = new DotColorizer();
            string dotsHtml = "abc"; // No dots, just characters

            // Act: Call the ColorDots method with the non-dot string.
            string result = dotColorizer.ColorDots(dotsHtml);

            // Assert: Verify that the output is an empty string since no dots should be colored.
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void ColorDots_CyclesColorsAfterFourDots()
        {
            // Arrange: Create an instance of DotColorizer and a string with more than four dots.
            var dotColorizer = new DotColorizer();
            string dotsHtml = "........"; // 8 dots, should repeat the color cycle

            // Act: Call the ColorDots method with the input string.
            string result = dotColorizer.ColorDots(dotsHtml);

            // Assert: Verify that the output contains the correct sequence of colored spans.
            string expectedOutput =
                "<span style='color: red'>. </span>" +
                "<span style='color: yellow'>. </span>" +
                "<span style='color: green'>. </span>" +
                "<span style='color: blue'>. </span>" +
                "<span style='color: red'>. </span>" +
                "<span style='color: yellow'>. </span>" +
                "<span style='color: green'>. </span>" +
                "<span style='color: blue'>. </span>";

            Assert.Equal(expectedOutput, result);
        }
    }
}