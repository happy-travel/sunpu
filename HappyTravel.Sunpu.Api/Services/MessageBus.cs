using System.Text.Json;
using NATS.Client;

namespace HappyTravel.Sunpu.Api.Services;

public class MessageBus : IMessageBus
{
    public MessageBus(IConnection connection)
    {
        _connection = connection;
    }


    /// <summary>
    /// Sent message to message bus
    /// </summary>
    /// <param name="topicName">Topic name</param>
    /// <param name="message">Message object</param>
    /// <typeparam name="T">Message type</typeparam>
    public void Publish<T>(string topicName, T message) 
        => _connection.Publish(topicName, JsonSerializer.SerializeToUtf8Bytes(message));


    private readonly IConnection _connection;
}