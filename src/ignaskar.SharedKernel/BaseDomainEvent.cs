using System;
using MediatR;

namespace ignaskar.SharedKernel
{
    public abstract class BaseDomainEvent : INotification
    {
        public DateTimeOffset DateOccured { get; protected set; } = DateTimeOffset.Now;
    }
}