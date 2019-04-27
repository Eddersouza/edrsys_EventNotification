namespace edrsys.EventNotification.Entities
{
    public class EventNotificationEntity
    {
        public EventNotification EventNotification { get; } = new EventNotification();

        public bool IsValid()
        {
            return !EventNotification.HasErrors
                && !EventNotification.HasWarnings;
        }

        public virtual void Validate()
        {
        }

        protected void Fail(
            bool condition,
            EventNotificationDescription description)
        {
            if (condition)
                EventNotification.Add(description);
        }

        protected void IsInvalidName(string s, EventNotificationDescription error)
        {
            Fail(string.IsNullOrWhiteSpace(s), error);
        }
    }
}