using edrsys.EventNotification.Base;
using edrsys.EventNotification.Levels;
using System.Collections.Generic;
using System.Linq;

namespace edrsys.EventNotification.Entities
{
    /// <summary>
    /// Event Notification.
    /// </summary>
    public class EventNotification : EventNotificationBase
    {
        /// <summary>
        /// List of Errors Event Notifications.
        /// </summary>
        public IList<EventNotificationDescription> Errors =>
            List.Cast<EventNotificationDescription>()
            .Where(x => x.Level is EventNotificationCritical).ToList();

        /// <summary>
        /// Has Error Event Notifications.
        /// </summary>
        public bool HasErrors =>
            List.Cast<EventNotificationDescription>()
            .Any(x => x.Level is EventNotificationCritical);

        /// <summary>
        /// Has Information Event Notifications.
        /// </summary>
        public bool HasInformations =>
            List.Cast<EventNotificationDescription>()
            .Any(x => x.Level is EventNotificationInformation);

        /// <summary>
        /// Has Warning Event Notifications.
        /// </summary>
        public bool HasWarnings =>
            List.Cast<EventNotificationDescription>()
            .Any(x => x.Level is EventNotificationWarning);

        /// <summary>
        /// Get Information Event Notifications.
        /// </summary>
        /// <returns>List of Information Event Notifications.</returns>
        public IList<EventNotificationDescription> Informations =>
            List.Cast<EventNotificationDescription>()
            .Where(x => x.Level is EventNotificationInformation).ToList();

        /// <summary>
        /// Get Warning Event Notifications.
        /// </summary>
        /// <returns>List of Warning Event Notifications.</returns>
        public IList<EventNotificationDescription> Warnings =>
            List.Cast<EventNotificationDescription>()
            .Where(x => x.Level is EventNotificationWarning).ToList();
    }
}