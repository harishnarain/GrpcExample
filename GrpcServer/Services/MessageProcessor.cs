namespace GrpcServer.Services
{
    public class MessageProcessor : IMessageProcessor
    {
        public async Task<string> ProcessMessageAsync(string message)
        {
            // Simulate an asynchronous task
            await Task.Delay(5000); // 5-second delay
            return $"Message received: {message}";
        }
    }
}
