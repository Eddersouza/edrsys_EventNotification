using edrsys.EventNotification.Contracts;

namespace edrsys.EventNotification.Levels
{
    /// <summary>
    /// Warning Event Notification.
    /// </summary>
    public class EventNotificationWarning : EventNotificationLevelContract
    {
        /// <summary>
        /// Create new Warning Event Notification.
        /// </summary>
        /// <param name="description">Description of Event Notification Level.</param>
        public EventNotificationWarning(string description = "Warning")
        {
            Description = description;
        }

        /// <summary>
        /// Description of Level Event.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Transform object in string.
        /// </summary>
        /// <returns>Object in string format.</returns>
        public override string ToString()
        {
            return Description;
        }
    }
}