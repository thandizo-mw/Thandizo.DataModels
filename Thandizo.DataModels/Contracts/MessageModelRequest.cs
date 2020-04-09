using Thandizo.DataModels.Messaging;

namespace Thandizo.DataModels.Contracts
{
    public class MessageModelRequest : IMessageModelRequest
    {
        public MessageModelRequest(MessageModel message)
        {
            Message = message;
        }
        public MessageModel Message { get; }
    }
}
