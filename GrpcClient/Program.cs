using Grpc.Net.Client;
using GrpcServer;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("http://localhost:5162");
            var client = new MessageService.MessageServiceClient(channel);

            var reply = await client.SendMessageAsync(new GrpcServer.MessageRequest { Message = "Hello, Server!" });

            Console.WriteLine("Response from server: " + reply.Response);
        }
    }
}