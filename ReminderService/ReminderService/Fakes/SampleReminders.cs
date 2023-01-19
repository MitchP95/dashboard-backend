namespace ReminderService.Fakes
{
    public static class SampleReminders
    {
        public static List<Reminder> GetSampleReminders ()
        {
            List<Reminder> reminders= new List<Reminder> ();

            reminders.Add(new Reminder()
            {
                Contributor = "Bob Kanakis",
                Description = "Pick a new first name for myself",
                DateTimeAdded= DateTime.Now,
                IsComplete= false,
            });

            reminders.Add(new Reminder()
            {
                Contributor = "Margret Kanakis",
                Description = "Help Bob pick a new name",
                DateTimeAdded = DateTime.Now,
                IsComplete = false,
            });

            return reminders;
        }
    }
}
