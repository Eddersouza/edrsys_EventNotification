using edrsys.EventNotification.Contracts;

namespace edrsys.EventNotification.Levels
{
    /// <summary>
    /// Critical Event Notification.
    /// </summary>
    public class EventNotificationCritical : EventNotificationLevelContract
    {
        /// <summary>
        /// Create new Critical Event Notification.
        /// </summary>
        /// <param name="description">Description of Event Notification Level.</param>
        public EventNotificationCritical(string description = "Critical")
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