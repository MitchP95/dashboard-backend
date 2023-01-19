using MySqlConnector;

namespace ReminderService.Communication
{
    public class ReminderMySQL
    {
        private string connectionString;

        public ReminderMySQL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Post(Reminder reminder)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "INSERT INTO reminders (contributor, description, date_time_added, date_time_completed, is_complete) VALUES (@contributor, @description, @date_time_added, @date_time_completed, @is_complete)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@contributor", reminder.Description);
                    command.Parameters.AddWithValue("@description", reminder.Description);
                    command.Parameters.AddWithValue("@date_time_added", reminder.Description);
                    command.Parameters.AddWithValue("@date_time_completed", reminder.Description);
                    command.Parameters.AddWithValue("@is_complete", reminder.Description);
                    command.ExecuteNonQuery();
                }
            }
            
        }
    }
}
