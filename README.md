
# gRPC Example with .NET 8

## Overview

This project demonstrates a basic gRPC implementation in .NET 8, including both server and client applications. The server processes messages sent by the client, simulating an asynchronous task.

## Project Structure

- **GrpcServer**: Contains the gRPC server implementation.
- **GrpcClient**: Contains the gRPC client implementation.

## Prerequisites

- .NET 8 SDK

## Setup Instructions

1. **Clone the Repository**

   ```sh
   git clone https://github.com/harishnarain/GrpcExample.git
   cd GrpcExample
   ```

2. **Navigate to the Server Project and Run**

   ```sh
   cd GrpcServer
   dotnet run
   ```

3. **Open a New Terminal, Navigate to the Client Project and Run**

   ```sh
   cd ../GrpcClient
   dotnet run
   ```

## Project Details

### gRPC Service Definition

The gRPC service is defined in the `message.proto` file located in the `Protos` directory of the `GrpcServer` project.

```proto
syntax = "proto3";

option csharp_namespace = "GrpcServer";

package message;

service MessageService {
    rpc SendMessage (MessageRequest) returns (MessageResponse);
}

message MessageRequest {
    string message = 1;
}

message MessageResponse {
    string response = 1;
}
```

### gRPC Server

The server-side implementation includes a business logic service and a gRPC service.

### gRPC Client

The client-side implementation sends a message to the server and prints the response.

## Notes

- Ensure the server is running on `http://localhost:5162`.
- Adjust the `Program.cs` in the client project to match the server's URL if it's different.

## License

This project is licensed under the MIT License.
