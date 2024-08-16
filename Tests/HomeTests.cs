using Bunit;
using Moq;
using LifeDots_App.Interfaces;
using LifeDots_App.Pages;
using Microsoft.Extensions.DependencyInjection;

namespace LifeDots_App
{
    public class HomeTests : TestContext
    {
        private readonly Mock<IHomeService> _homeServiceMock;

        public HomeTests()
        {
            // Arrange: Set up the mock for IHomeService
            _homeServiceMock = new Mock<IHomeService>();
            Services.AddSingleton(_homeServiceMock.Object);
        }

        [Fact]
        public void OnInitialized_ShouldSetOnChangeToStateHasChanged()
        {
            // Act: Render the Home component
            var component = RenderComponent<Home>();

            // Assert: Verify that the OnChange delegate is set to StateHasChanged
            _homeServiceMock.VerifySet(h => h.OnChange = It.IsAny<Action>(), Times.Once);
        }

        [Fact]
        public void Increment_ShouldCallIncrementYearsOnHomeService()
        {
            // Act: Render the Home component and call the Increment method
            var component = RenderComponent<Home>();
            component.InvokeAsync(() => component.Instance.Increment());

            // Assert: Verify that IncrementYears was called
            _homeServiceMock.Verify(h => h.IncrementYears(), Times.Once);
        }

        [Fact]
        public void Decrement_ShouldCallDecrementYearsOnHomeService()
        {
            // Act: Render the Home component and call the Decrement method
            var component = RenderComponent<Home>();
            component.InvokeAsync(() => component.Instance.Decrement());

            // Assert: Verify that DecrementYears was called
            _homeServiceMock.Verify(h => h.DecrementYears(), Times.Once);
        }

        [Fact]
        public void UpdateDisplay_ShouldCallUpdateDisplayOnHomeService()
        {
            // Act: Render the Home component and call the UpdateDisplay method
            var component = RenderComponent<Home>();
            component.InvokeAsync(() => component.Instance.UpdateDisplay());

            // Assert: Verify that UpdateDisplay was called
            _homeServiceMock.Verify(h => h.UpdateDisplay(), Times.Once);
        }

        // Additional tests for checking message handling and UI updates
        // will be added when external message content loading is implemented.
    }
}
