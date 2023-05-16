using CM_Test.Model;
using CM_Test.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CM_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageRepository _messageRepository;

        public MessageController(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        [HttpPost]
        public async Task<IActionResult> PostMessage(MessageData messageData)
        {
            HttpStatusCode statusCode = await _messageRepository.PostMessage(messageData);
            if (statusCode == HttpStatusCode.OK)
            {
                return Ok();
            }
            else
            {
                return StatusCode((int)statusCode);
            }
        }
    }
}
