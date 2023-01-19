namespace ReminderService
{
    public class Reminder
    {
        public string Contributor { get; set; }

        public string Description { get; set; }

        public DateTime DateTimeAdded { get; set; }

        public DateTime? DateTimeCompleted { get; set; }

        public bool IsComplete { get; set; }
    }
}
