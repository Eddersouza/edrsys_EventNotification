using edrsys.EventNotification.Contracts;
using edrsys.EventNotification.Entities;
using System.Collections;

namespace edrsys.EventNotification
{
    /// <summary>
    /// Event notification Service.
    /// </summary>
    public abstract class EventNotificationServices
        : EventNotificationServiceContract
    {
        /// <summary>
        /// Store entity Event Notifications.
        /// </summary>
        protected EventNotificationEntity NotificationEntity;

        /// <summary>
        /// Has Error Event Notifications.
        /// </summary>
        public bool HasErrors =>
            NotificationEntity != null
            && NotificationEntity.EventNotification.HasErrors;

        /// <summary>
        /// Has Information Event Notifications.
        /// </summary>
        public bool HasInformations =>
            NotificationEntity != null
            && NotificationEntity.EventNotification.HasInformations;

        /// <summary>
        /// Has Notifications.
        /// </summary>
        public bool HasNotifications =>
            NotificationEntity != null
            && NotificationEntity.EventNotification.HasNotifications;

        /// <summary>
        /// Has Warning Event Notifications.
        /// </summary>
        public bool HasWarnings =>
            NotificationEntity != null
            && NotificationEntity.EventNotification.HasWarnings;

        /// <summary>
        /// Object is Valid.
        /// </summary>
        public bool IsValid => !HasErrors && !HasWarnings;

        /// <summary>
        /// Get Error Event Notifications.
        /// </summary>
        /// <returns>List of Error Event Notifications.</returns>
        public IEnumerable Errors()
        {
            return NotificationEntity?.EventNotification.Errors;
        }

        /// <summary>
        /// Get Information Event Notifications.
        /// </summary>
        /// <returns>List of Information Event Notifications.</returns>
        public IEnumerable Informations()
        {
            return NotificationEntity?.EventNotification.Informations;
        }

        /// <summary>
        /// Get Warning Event Notifications.
        /// </summary>
        /// <returns>List of Warning Event Notifications.</returns>
        public IEnumerable Warnings()
        {
            return NotificationEntity?.EventNotification.Warnings;
        }
    }
}