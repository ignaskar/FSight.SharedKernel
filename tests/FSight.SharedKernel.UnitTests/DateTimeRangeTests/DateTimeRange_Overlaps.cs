using System;
using FluentAssertions;
using Xunit;

namespace FSight.SharedKernel.UnitTests.DateTimeRangeTests
{
    public class DateTimeRange_Overlaps
    {
        [Fact]
        public void ReturnsTrueGivenSameDateTimeRange()
        {
            var dtr = new DateTimeRange(DateTimes.TestDateTime, TimeSpan.FromHours(1));

            var result = dtr.Overlaps(dtr);

            result.Should().BeTrue();
        }

        [Fact]
        public void ReturnsTrueGivenEarlierRangeExceedingStart()
        {
            var dtr = new DateTimeRange(DateTimes.TestDateTime, TimeSpan.FromHours(1));
            var earlier = new DateTimeRange(DateTimes.TestDateTime.AddMinutes(5), TimeSpan.FromMinutes(10));

            var result = dtr.Overlaps(earlier);

            result.Should().BeTrue();
        }

        [Fact]
        public void ReturnsTrueGivenRangeWithinRange()
        {
            var dtr = new DateTimeRange(DateTimes.TestDateTime, TimeSpan.FromHours(1));
            var within = new DateTimeRange(DateTimes.TestDateTime.AddMinutes(-5), TimeSpan.FromMinutes(10));

            var result = dtr.Overlaps(within);

            result.Should().BeTrue();
        }

        [Fact]
        public void ReturnsTrueGivenRangeStartingWithinRangeEndingLater()
        {
            var dtr = new DateTimeRange(DateTimes.TestDateTime, TimeSpan.FromHours(1));
            var endsLater = new DateTimeRange(dtr.End.AddMinutes(-5), TimeSpan.FromMinutes(10));

            var result = dtr.Overlaps(endsLater);

            result.Should().BeTrue();
        }

        [Fact]
        public void ReturnsFalseGivenRangeEndingBeforeStart()
        {
            var dtr = new DateTimeRange(DateTimes.TestDateTime, TimeSpan.FromHours(1));
            var endsEarlier = new DateTimeRange(dtr.Start.AddHours(-1), TimeSpan.FromMinutes(10));

            var result = dtr.Overlaps(endsEarlier);

            result.Should().BeFalse();
        }

        [Fact]
        public void ReturnsFalseGivenRangeStartingAfterEnd()
        {
            var dtr = new DateTimeRange(DateTimes.TestDateTime, TimeSpan.FromHours(1));
            var startsLater = new DateTimeRange(dtr.End.AddMinutes(1), TimeSpan.FromMinutes(20));

            var result = dtr.Overlaps(startsLater);

            result.Should().BeFalse();
        }
    }
}