using CM_Test.Model;
using System.Net;

namespace CM_Test.Repository
{
    public interface IMessageRepository
    {
        Task<HttpStatusCode> PostMessage(MessageData messageData);
    }
}
