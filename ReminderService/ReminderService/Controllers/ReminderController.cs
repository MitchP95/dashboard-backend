using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using ReminderService.Fakes;

namespace ReminderService.Controllers
{
    [ApiController]
    [Route("[reminderController]")]
    public class ReminderController : ControllerBase
    {
        [HttpGet(Name = "GetReminders")]
        public IEnumerable<Reminder> Get()
        {
            return SampleReminders.GetSampleReminders();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Reminder reminder)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "INSERT INTO reminders (title, description, reminder_date) VALUES (@title, @description, @reminder_date)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@title", reminder.Title);
                    command.Parameters.AddWithValue("@description", reminder.Description);
                    command.Parameters.AddWithValue("@reminder_date", reminder.ReminderDate);
                    command.ExecuteNonQuery();
                }
            }
            return Ok();
        }
    }
}
