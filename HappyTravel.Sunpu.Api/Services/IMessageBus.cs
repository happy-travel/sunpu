namespace HappyTravel.Sunpu.Api.Services;

public interface IMessageBus
{
    /// <summary>
    /// Sent message to message bus
    /// </summary>
    /// <param name="topicName">Topic name</param>
    /// <param name="message">Message object</param>
    /// <typeparam name="T">Message type</typeparam>
    void Publish<T>(string topicName, T message);
}