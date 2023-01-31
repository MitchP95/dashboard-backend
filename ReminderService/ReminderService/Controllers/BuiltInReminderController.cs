using Microsoft.AspNetCore.Mvc;
using ReminderService.Fakes;

namespace ReminderService.Controllers
{
    [ApiController]
    [Route("controller")]
    public class BuiltInReminderController : ControllerBase
    {
        [HttpGet(Name = "GetBuiltInReminders")]
        public IEnumerable<Reminder> Get()
        {
            return SampleReminders.GetSampleReminders();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Reminder reminder)
        {
            return NoContent();
        }
    }
}
