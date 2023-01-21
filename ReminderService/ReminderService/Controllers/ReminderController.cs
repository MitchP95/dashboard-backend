using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using ReminderService.Communication;
using ReminderService.Fakes;

namespace ReminderService.Controllers
{
    [ApiController]
    [Route("[reminderController]")]
    public class ReminderController : ControllerBase
    {
        private ReminderMySQL mySql;

        public ReminderController(
            ReminderMySQL mySql) { 
            this.mySql = mySql;
        }

        [HttpGet(Name = "GetReminders")]
        public IEnumerable<Reminder> Get()
        {
            return this.mySql.GetReminders();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Reminder reminder)
        {
            this.mySql.PostReminder(reminder);
            return Ok();
        }
    }
}
