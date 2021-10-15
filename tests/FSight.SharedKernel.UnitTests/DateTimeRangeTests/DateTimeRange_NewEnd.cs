using System;
using FluentAssertions;
using Xunit;

namespace FSight.SharedKernel.UnitTests.DateTimeRangeTests
{
    public class DateTimeRange_NewEnd
    {
        [Fact]
        public void ReturnsNewObjectWithGivenEndDate()
        {
            var newEndTime = DateTimes.TestDateTime.AddHours(2);
            var dtr = new DateTimeRange(DateTimes.TestDateTime, TimeSpan.FromHours(1));

            var newDtr = dtr.NewEnd(newEndTime);

            dtr.Should().NotBeSameAs(newDtr);
            newDtr.End.Should().Be(newEndTime);
        }
    }
}