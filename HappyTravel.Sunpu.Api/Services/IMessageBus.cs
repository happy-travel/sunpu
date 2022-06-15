namespace HappyTravel.Sunpu.Api.Services;

public interface IMessageBus
{
    void Publish<T>(string topicName, T message);
}