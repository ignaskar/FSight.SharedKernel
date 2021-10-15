using System;
using MediatR;

namespace FSight.SharedKernel
{
    public abstract class BaseIntegrationEvent : INotification
    {
        /// <summary>
        /// Integration events are used to communicate between bounded contexts and/or applications.
        /// They are often mapped from domain events in the notifying system 
        /// and sometimes to domain events in the consuming system
        /// </summary>
        public DateTimeOffset DateOccured { get; set; } = DateTime.UtcNow;
        string EventType { get; }
    }
}