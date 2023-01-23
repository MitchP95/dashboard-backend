using Microsoft.AspNetCore.Mvc;
using ReminderService.Fakes;

namespace ReminderService.Controllers
{
    [ApiController]
    [Route("[builtInReminderController]")]
    public class BuiltInReminderController : ControllerBase
    {
        [HttpGet(Name = "GetReminders")]
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
