using edrsys.EventNotification.Contracts;

namespace edrsys.EventNotification.Levels
{
    /// <summary>
    /// Information Event Notification.
    /// </summary>
    public class EventNotificationInformation : EventNotificationLevelContract
    {
        /// <summary>
        /// Create new Information Event Notification.
        /// </summary>
        /// <param name="description">Description of Event Notification Level.</param>
        public EventNotificationInformation(string description = "Information")
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