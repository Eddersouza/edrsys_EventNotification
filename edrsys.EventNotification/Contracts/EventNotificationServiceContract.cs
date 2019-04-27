using System.Collections;

namespace edrsys.EventNotification.Contracts
{
    /// <summary>
    /// Event Notification Service.
    /// </summary>
    public interface EventNotificationServiceContract
    {
        /// <summary>
        /// Has Error Event Notifications.
        /// </summary>
        bool HasErrors { get; }

        /// <summary>
        /// Has Information Event Notifications.
        /// </summary>
        bool HasInformations { get; }

        /// <summary>
        /// Has Notifications.
        /// </summary>
        bool HasNotifications { get; }

        /// <summary>
        /// Has Warning Event Notifications.
        /// </summary>
        bool HasWarnings { get; }

        /// <summary>
        /// Object is Valid.
        /// </summary>
        bool IsValid { get; }

        /// <summary>
        /// Get Error Event Notifications.
        /// </summary>
        /// <returns>List of Error Event Notifications.</returns>
        IEnumerable Errors();

        /// <summary>
        /// Get Information Event Notifications.
        /// </summary>
        /// <returns>List of Information Event Notifications.</returns>
        IEnumerable Informations();

        /// <summary>
        /// Get Warning Event Notifications.
        /// </summary>
        /// <returns>List of Warning Event Notifications.</returns>
        IEnumerable Warnings();
    }
}