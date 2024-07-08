using Grpc.Core;

namespace GrpcServer.Services
{
    public class GrpcMessageService : GrpcServer.MessageService.MessageServiceBase, IGrpcMessageService
    {
        private readonly IMessageProcessor _messageProcessor;

        public GrpcMessageService(IMessageProcessor messageProcessor)
        {
            _messageProcessor = messageProcessor;
        }

        public override async Task<MessageResponse> SendMessage(MessageRequest request, ServerCallContext context)
        {
            // Log the received message to the console
            Console.WriteLine($"Received message: {request.Message}");

            // Process the message using the business logic service
            var responseMessage = await _messageProcessor.ProcessMessageAsync(request.Message);

            return new MessageResponse
            {
                Response = responseMessage
            };
        }
    }
}
