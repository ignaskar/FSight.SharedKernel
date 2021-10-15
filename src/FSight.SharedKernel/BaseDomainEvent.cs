using System;
using MediatR;

namespace FSight.SharedKernel
{
    public abstract class BaseDomainEvent : INotification
    {
        public DateTimeOffset DateOccured { get; protected set; } = DateTimeOffset.Now;
    }
}