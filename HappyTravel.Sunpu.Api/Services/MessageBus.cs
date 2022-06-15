using System.Text.Json;
using NATS.Client;

namespace HappyTravel.Sunpu.Api.Services;

public class MessageBus : IMessageBus
{
    public MessageBus(IConnection connection)
    {
        _connection = connection;
    }


    public void Publish<T>(string topicName, T message) 
        => _connection.Publish(topicName, JsonSerializer.SerializeToUtf8Bytes(message));


    private readonly IConnection _connection;
}