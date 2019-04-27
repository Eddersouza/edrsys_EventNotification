namespace edrsys.EventNotification.Contracts
{
    /// <summary>
    /// Event Notification Level.
    /// </summary>
    public interface EventNotificationLevelContract
    {
        /// <summary>
        /// Level Description.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Transform object in string.
        /// </summary>
        /// <returns>Object in string.</returns>
        string ToString();
    }
}