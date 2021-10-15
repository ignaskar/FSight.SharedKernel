using System;
using System.Collections.Generic;
using Ardalis.GuardClauses;

namespace FSight.SharedKernel.Guards
{
    public static class CustomGuards
    {
        public static DateTimeOffset OutOfRange(
            this IGuardClause guardClause, 
            DateTimeOffset input,
            string parameterName, 
            DateTimeOffset rangeFrom, 
            DateTimeOffset rangeTo)
        {
            return OutOfRange<DateTimeOffset>(guardClause, input, parameterName, rangeFrom, rangeTo);
        }

        private static T OutOfRange<T>(
            this IGuardClause guardClause, 
            T input, 
            string parameterName, 
            T rangeFrom,
            T rangeTo)
        {
            var comparer = Comparer<T>.Default;

            if (comparer.Compare(rangeFrom, rangeTo) > 0)
            {
                throw new ArgumentException($"{nameof(rangeFrom)} should be less or equal to {nameof(rangeTo)}");
            }

            if (comparer.Compare(input, rangeFrom) < 0 || comparer.Compare(input, rangeTo) > 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, $"Input {parameterName} was out of range");
            }

            return input;
        }
    }
}