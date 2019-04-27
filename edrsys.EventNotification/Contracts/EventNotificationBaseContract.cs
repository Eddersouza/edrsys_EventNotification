using edrsys.EventNotification.Base;
using System.Collections.Generic;

namespace edrsys.EventNotification.Contracts
{
    /// <summary>
    /// Event Notification Base.
    /// </summary>
    public interface EventNotificationBaseContract
    {
        /// <summary>
        /// Exists Notifications.
        /// </summary>
        bool HasNotifications { get; }

        /// <summary>
        /// List of Event Notifications.
        /// </summary>
        IList<object> List { get; }

        /// <summary>
        /// Add Event notification.
        /// </summary>
        /// <param name="eventNotification">Event Notification.</param>
        void Add(EventNotificationDescriptionBase eventNotification);

        /// <summary>
        /// Verify if Event Notification exist in List.
        /// </summary>
        /// <param name="eventNotification">Event Notification.</param>
        /// <returns>True if exist.</returns>
        bool Includes(EventNotificationDescriptionBase eventNotification);
    }
}