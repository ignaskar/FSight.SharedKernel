using FluentAssertions;
using Xunit;

namespace FSight.SharedKernel.UnitTests.DateTimeRangeTests
{
    public class DateTimeRange_CreateOneWeekRange
    {
        [Fact]
        public void CreatesRangeWithStartDateLastingSevenDays()
        {
            var dtr = DateTimeRange.CreateOneWeekRange(DateTimes.TestDateTime);

            dtr.Start.Should().Be(DateTimes.TestDateTime);
            dtr.End.Should().Be(DateTimes.TestDateTime.AddDays(7));
        }
    }
}