using edrsys.EventNotification.Contracts;

namespace edrsys.EventNotification.Base
{
    /// <summary>
    /// Event Notification Base
    /// </summary>
    public abstract class EventNotificationDescriptionBase : EventNotificationDescriptionBaseContract
    {
        /// <summary>
        /// Create new Event Description Base.
        /// </summary>
        /// <param name="message">Message to Event Notification Description. May be a format pattern, ex.: The value is {0}.</param>
        /// <param name="args">Arguments to pass to the message if is a format pattern.</param>
        protected EventNotificationDescriptionBase(string message, params string[] args)
        {
            Message = message;

            for (var i = 0; i < args.Length; i++)
            {
                Message = Message.Replace("{" + i + "}", args[i]);
            }
        }

        /// <summary>
        /// Event notification Message.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Transform object in string.
        /// </summary>
        /// <returns>Object in string format.</returns>
        public override string ToString() => Message;
    }
}