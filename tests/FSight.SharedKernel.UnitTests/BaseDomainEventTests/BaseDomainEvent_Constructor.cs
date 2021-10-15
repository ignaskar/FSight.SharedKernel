using System;
using FluentAssertions;
using Xunit;

namespace FSight.SharedKernel.UnitTests.BaseDomainEventTests
{
    public class BaseDomainEvent_Constructor
    {
        public class TestEvent : BaseDomainEvent
        { }

        [Fact]
        public void SetsTimeToCurrentTime()
        {
            var newEvent = new TestEvent();

            newEvent.DateOccured.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromMilliseconds(100));
        }
    }
}