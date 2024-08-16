using LifeDots_App.Services;

namespace LifeDots_App.Tests.Services
{
    public class MessageServiceTests
    {
        private readonly MessageService _messageService;

        public MessageServiceTests()
        {
            // Arrange: Initialize the MessageService
            _messageService = new MessageService();
        }

        [Theory]
        [InlineData(10, 520)]
        [InlineData(5, 260)]
        public void GenerateMainMessage_ShouldReturnExpectedMessage_WhenMessagesAreHardcoded(int yearsToDie, int weeksToDie)
        {
            // Test case for hardcoded messages.
            // Unit tests for message generation will be added when external message content loading is implemented.
        }

        [Fact]
        public void GenerateSecondaryMessage_ShouldReturnExpectedMessage_WhenMessagesAreHardcoded()
        {
            // Test case for hardcoded messages.
            // Unit tests for secondary message generation will be added when external message content loading is implemented.
        }

        [Theory]
        [InlineData(10, true)]
        [InlineData(0, false)]
        [InlineData(-1, false)]
        public void ShouldDisplayMessages_ReturnsExpectedResult(int yearsToDie, bool expectedResult)
        {
            // Act: Call ShouldDisplayMessages with different yearsToDie values
            var result = _messageService.ShouldDisplayMessages(yearsToDie);

            // Assert: Verify that the result matches the expected value
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ClearMessages_ShouldSetMessagesToEmptyStrings()
        {
            // Act: Call ClearMessages
            _messageService.ClearMessages(out string message, out string secondMessage);

            // Assert: Verify that both messages are set to empty strings
            Assert.Equal(string.Empty, message);
            Assert.Equal(string.Empty, secondMessage);
        }

        [Theory]
        [InlineData(10, 520)]
        [InlineData(5, 260)]
        public void UpdateMessages_ShouldUpdateMessages_WhenMessagesAreHardcoded(int yearsToDie, int weeksToDie)
        {
            // Test case for updating messages with hardcoded content.
            // Unit tests for updating messages will be added when external message content loading is implemented.
        }
    }
}
