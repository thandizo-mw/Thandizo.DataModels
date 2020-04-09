using System.Collections.Generic;

namespace Thandizo.DataModels.Messaging
{
    public class MessageModel
    {
        public string MessageBody { get; set; }
        public string SourceAddress { get; set; }
        public IList<string> DestinationRecipients { get; } = new List<string>();
        public string Subject { get; set; }
    }
}
