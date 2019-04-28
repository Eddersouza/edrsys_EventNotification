namespace edrsys.EventNotification.Entities
{
    /// <summary>
    /// Base Event Notification.
    /// </summary>
    public class EventNotificationEntity
    {
        /// <summary>
        /// Event notification.
        /// </summary>
        public EventNotification EventNotification { get; } = new EventNotification();

        /// <summary>
        /// Entity is valid.
        /// </summary>
        /// <returns></returns>
        public bool IsValid()
        {
            return !EventNotification.HasErrors
                && !EventNotification.HasWarnings;
        }

        /// <summary>
        /// Test Contition.
        /// </summary>
        /// <param name="condition">Condition to test.</param>
        /// <param name="description">Description id atend condition.</param>
        protected void TestCondition(
            bool condition,
            EventNotificationDescription description)
        {
            if (condition)
                EventNotification.Add(description);
        }

        /// <summary>
        /// Test if field is Empty.
        /// </summary>
        /// <param name="field">Value of the field.</param>
        /// <param name="eventDescription">Description if field is empty.</param>
        protected void TestFieldIsEmpty(
            string field, 
            EventNotificationDescription eventDescription)
        {
            TestCondition(string.IsNullOrWhiteSpace(field), eventDescription);
        }        
    }
}