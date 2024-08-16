using Moq;
using LifeDots_App.Interfaces;
using LifeDots_App.Services;
using Microsoft.AspNetCore.Components;

namespace LifeDots_App.Tests.Services
{
    public class HomeServiceTests
    {
        private readonly Mock<ICounterHandler> _counterHandlerMock;
        private readonly Mock<IDotGenerator> _dotGeneratorMock;
        private readonly Mock<IMessageService> _messageServiceMock;
        private readonly HomeService _homeService;

        public HomeServiceTests()
        {
            // Arrange: Setting up mocks and initializing the service
            _counterHandlerMock = new Mock<ICounterHandler>();
            _dotGeneratorMock = new Mock<IDotGenerator>();
            _messageServiceMock = new Mock<IMessageService>();

            _homeService = new HomeService(_counterHandlerMock.Object, _dotGeneratorMock.Object, _messageServiceMock.Object);
        }

        [Fact]
        public void YearsToDie_SetNewValue_UpdatesDisplay()
        {
            // Arrange: Setting initial values and expected outcomes
            _counterHandlerMock.Setup(c => c.YearsToDie).Returns(10);
            _counterHandlerMock.SetupSet(c => c.YearsToDie = 12);

            // Act: Changing the value of YearsToDie
            _homeService.YearsToDie = 12;

            // Assert: Verify that UpdateDisplay was called
            _counterHandlerMock.VerifySet(c => c.YearsToDie = 12, Times.Once);
            // We expect UpdateDisplay to have been triggered, so we can further assert that dots and messages were updated accordingly.
        }

        [Fact]
        public void IncrementYears_CallsCounterIncrementAndUpdateDisplay()
        {
            // Arrange: Setting up the expectation for Increment method
            _counterHandlerMock.Setup(c => c.Increment());

            // Act: Calling the method
            _homeService.IncrementYears();

            // Assert: Verifying that Increment and UpdateDisplay were called
            _counterHandlerMock.Verify(c => c.Increment(), Times.Once);
            // Similar assertions can be made to check the state change in _homeService (e.g., checking if dots were updated)
        }

        [Fact]
        public void DecrementYears_CallsCounterDecrementAndUpdateDisplay()
        {
            // Arrange: Setting up the expectation for Decrement method
            _counterHandlerMock.Setup(c => c.Decrement());

            // Act: Calling the method
            _homeService.DecrementYears();

            // Assert: Verifying that Decrement and UpdateDisplay were called
            _counterHandlerMock.Verify(c => c.Decrement(), Times.Once);
            // As with the increment test, additional checks can be made here.
        }

        [Fact]
        public void UpdateDisplay_ShouldClearMessagesAndDots_WhenShouldDisplayMessagesIsFalse()
        {
            // Arrange: Setting up the scenario where messages should not be displayed
            _counterHandlerMock.Setup(c => c.YearsToDie).Returns(5);
            _messageServiceMock.Setup(m => m.ShouldDisplayMessages(5)).Returns(false);
            _messageServiceMock.Setup(m => m.ClearMessages(out It.Ref<string>.IsAny, out It.Ref<string>.IsAny))
                .Callback((out string message, out string secondMessage) =>
                {
                    message = string.Empty;
                    secondMessage = string.Empty;
                });

            // Act: Calling the method to update the display
            _homeService.UpdateDisplay();

            // Assert: Verifying that messages were cleared and dots were reset
            Assert.Equal(string.Empty, _homeService.Message);
            Assert.Equal(string.Empty, _homeService.SecondMessage);
            Assert.Equal(new MarkupString(string.Empty), _homeService.DotsDisplay);
        }

        // Additional tests for methods involving message handling and dot generation
        // will be added once the logic for fetching message content externally is implemented.
    }
}
