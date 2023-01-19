using Microsoft.AspNetCore.Mvc;

namespace ReminderService.Controllers
{
    [ApiController]
    [Route("[reminderController]")]
    public class ReminderController : ControllerBase
    {
        [HttpGet(Name = "GetReminders")]
        public IEnumerable<Reminder> Get()
        {
            return new List<Reminder>();
        } 
    }
}
