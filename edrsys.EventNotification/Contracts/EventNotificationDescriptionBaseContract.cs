namespace edrsys.EventNotification.Contracts
{
    /// <summary>
    /// Event Notification Base.
    /// </summary>
    public interface EventNotificationDescriptionBaseContract
    {
        /// <summary>
        /// Message Event Notification.
        /// </summary>
        string Message { get; }

        /// <summary>
        /// Transform object in string.
        /// </summary>
        /// <returns>Object in string Format.</returns>
        string ToString();
    }
}