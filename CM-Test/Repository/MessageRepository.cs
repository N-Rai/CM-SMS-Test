using CM_Test.Model;
using System.Net;

namespace CM_Test.Repository
{
    public class MessageRepository : IMessageRepository
    {
        private readonly HttpClient _httpClient;

        public MessageRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<HttpStatusCode> PostMessage(MessageData messageData)
        {
            string apiWrl = "https://gw.cmtelecom.com/v1.0/message";
            HttpResponseMessage respone = await _httpClient.PostAsJsonAsync(apiWrl, messageData);
            return respone.StatusCode;
        }
    }
}
