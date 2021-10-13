using System;
using System.Collections.Generic;
using Ardalis.GuardClauses;
using ignaskar.SharedKernel.Guards;

namespace ignaskar.SharedKernel
{
    public class DateTimeOffsetRange : ValueObject
    {
        public DateTimeOffset Start { get; private set; }
        public DateTimeOffset End { get; private set; }

        public DateTimeOffsetRange(DateTimeOffset start, DateTimeOffset end)
        {
            Guard.Against.OutOfRange(start, nameof(start), start, end);
            Start = start;
            End = end;
        }

        // TODO: Add factory methods
        
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Start;
            yield return End;
        }
    }
}