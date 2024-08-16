using LifeDots_App.Services;

namespace LifeDots_App.Tests.Services
{
    public class CounterHandlerTests
    {
        // Test to check if setting a valid value updates the YearsToDie property correctly.
        [Fact]
        public void YearsToDie_SetValidValue_UpdatesProperty()
        {
            // Arrange: Create an instance of CounterHandler and set the initial value of YearsToDie to 10.
            CounterHandler counter = new()
            {
                // Act: Assign the value 10 to the YearsToDie property.
                YearsToDie = 10
            };

            // Assert: Verify that the YearsToDie property was updated correctly and now equals 10.
            Assert.Equal(10, counter.YearsToDie);
        }

        // Test to check if setting a negative value does not change the YearsToDie property.
        [Fact]
        public void YearsToDie_SetNegativeValue_DoesNotUpdateProperty()
        {
            // Arrange: Create an instance of CounterHandler and set the initial value of YearsToDie to 10.
            CounterHandler counter = new()
            {
                YearsToDie = 10
            };

            // Act: Attempt to set the YearsToDie property to a negative value (-5).
            counter.YearsToDie = -5;

            // Assert: Verify that the YearsToDie property did not change and remains 10.
            Assert.Equal(10, counter.YearsToDie); // Value should remain unchanged
        }

        // Test to ensure that the WeeksToDie property correctly calculates the number of weeks based on YearsToDie.
        [Fact]
        public void WeeksToDie_CorrectlyCalculatesWeeks()
        {
            // Arrange: Create an instance of CounterHandler and set the YearsToDie property to 2.
            CounterHandler counter = new()
            {
                YearsToDie = 2
            };

            // Act: Calculate the number of weeks using the WeeksToDie property.
            int weeks = counter.WeeksToDie;

            // Assert: Verify that the WeeksToDie property correctly calculates the weeks as 2 * 52 = 104 weeks.
            Assert.Equal(104, weeks);
        }

        // Test to check if the Increment method correctly increases the YearsToDie property by 1.
        [Fact]
        public void Increment_IncreasesYearsToDieByOne()
        {
            // Arrange: Create an instance of CounterHandler and set the initial value of YearsToDie to 5.
            CounterHandler counter = new()
            {
                YearsToDie = 5
            };

            // Act: Call the Increment method to increase the YearsToDie property by 1.
            counter.Increment();

            // Assert: Verify that the YearsToDie property has increased to 6.
            Assert.Equal(6, counter.YearsToDie);
        }

        // Test to check if the Decrement method correctly decreases the YearsToDie property by 1.
        [Fact]
        public void Decrement_DecreasesYearsToDieByOne()
        {
            // Arrange: Create an instance of CounterHandler and set the initial value of YearsToDie to 5.
            CounterHandler counter = new()
            {
                YearsToDie = 5
            };

            // Act: Call the Decrement method to decrease the YearsToDie property by 1.
            counter.Decrement();

            // Assert: Verify that the YearsToDie property has decreased to 4.
            Assert.Equal(4, counter.YearsToDie);
        }

        // Test to ensure that the Decrement method does not decrease the YearsToDie property below 0.
        [Fact]
        public void Decrement_DoesNotDecreaseBelowZero()
        {
            // Arrange: Create an instance of CounterHandler and set the initial value of YearsToDie to 0.
            CounterHandler counter = new()
            {
                YearsToDie = 0
            };

            // Act: Call the Decrement method, which should not decrease the value below 0.
            counter.Decrement();

            // Assert: Verify that the YearsToDie property remains 0, as it should not decrease below zero.
            Assert.Equal(0, counter.YearsToDie); // Value should not go below zero
        }
    }
}