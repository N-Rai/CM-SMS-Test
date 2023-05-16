using CM.Text.BusinessMessaging.Model;

namespace CM_Test.Model
{
    public class Msg
    {
        public List<String> AllowedChannels { get; set; }
        public string From { get; set; }
        public List<Recipient> To { get; set; }
        public int MinimumNumberOfMessageParts { get; set; }
        public int MaximumNumberOfMessageParts { get; set; }
        public MessageBody Body { get; set; }

    }
}
