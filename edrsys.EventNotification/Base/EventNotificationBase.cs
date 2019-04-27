using edrsys.EventNotification.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace edrsys.EventNotification.Base
{
    /// <summary>
    /// Event Notification Base.
    /// </summary>
    public abstract class EventNotificationBase : EventNotificationBaseContract
    {
        /// <summary>
        /// Exists Event Notifications.
        /// </summary>
        public bool HasNotifications => List.Any();

        /// <summary>
        /// List of Event Notifications.
        /// </summary>
        public IList<object> List { get; } = new List<object>();

        /// <summary>
        /// Add Event notification.
        /// </summary>
        /// <param name="eventNotification">Event Notification.</param>
        public void Add(EventNotificationDescriptionBase eventNotification)
        {
            List.Add(eventNotification);
        }

        /// <summary>
        /// Verify if Event Notification exist in List.
        /// </summary>
        /// <param name="eventNotification">Event Notification.</param>
        /// <returns>True if exist.</returns>
        public bool Includes(EventNotificationDescriptionBase eventNotification)
        {
            return List.Contains(eventNotification);
        }
    }
}