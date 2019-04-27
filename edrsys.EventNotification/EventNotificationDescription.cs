using edrsys.EventNotification.Base;
using edrsys.EventNotification.Contracts;

namespace edrsys.EventNotification
{
    /// <summary>
    /// Event notification description.
    /// </summary>
    public class EventNotificationDescription : EventNotificationDescriptionBase
    {
        /// <summary>
        /// Create new Event Notification Description.
        /// </summary>
        /// <param name="message">Message to Event Notification Description. May be a format pattern, ex.: The value is {0}.</param>
        /// <param name="level">Level Of Event Notification.</param>
        /// <param name="args">Arguments to pass to the message if is a format pattern.</param>
        public EventNotificationDescription(
            string message,
            EventNotificationLevelContract level,
            params string[] args)
            : base(message, args)
        {
            Level = level;
        }

        /// <summary>
        /// Instance of Event Notification Level.
        /// </summary>
        public EventNotificationLevelContract Level { get; }
    }
}