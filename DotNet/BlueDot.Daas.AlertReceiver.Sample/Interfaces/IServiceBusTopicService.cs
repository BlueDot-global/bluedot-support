using Azure.Messaging.ServiceBus;
using System;
using System.Threading.Tasks;

namespace BlueDot.Daas.AlertReceiver.Sample.Interfaces
{
    public interface IServiceBusTopicService
    {
        Task SendMessageToTopicAsync(string messageBody);
        Task<ServiceBusProcessor> GetServiceBusProcessorAsync(Func<ProcessMessageEventArgs, Task> MessageHandler,
           Func<ProcessErrorEventArgs, Task> ErrorHandler);
    }
}
