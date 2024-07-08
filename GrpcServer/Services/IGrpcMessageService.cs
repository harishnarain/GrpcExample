using Grpc.Core;

namespace GrpcServer.Services
{
    public interface IGrpcMessageService
    {
        Task<MessageResponse> SendMessage(MessageRequest request, ServerCallContext context);
    }
}
