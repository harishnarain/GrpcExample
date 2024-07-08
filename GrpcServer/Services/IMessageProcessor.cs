namespace GrpcServer.Services
{
    public interface IMessageProcessor
    {
        Task<string> ProcessMessageAsync(string message);
    }
}
