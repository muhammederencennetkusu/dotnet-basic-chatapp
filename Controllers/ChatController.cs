using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalRChatApp.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRChatApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly ChatContext _context;

        public ChatController(ChatContext context)
        {
            _context = context;
        }

        [HttpGet("messages")]
        public async Task<IActionResult> GetMessages()
        {
            var messages = await _context.Messages
                .OrderBy(m => m.Timestamp)
                .Select(m => new
                {
                    m.UserName,
                    m.MessageContent
                })
                .ToListAsync();

            return Ok(messages);
        }
    }
}
