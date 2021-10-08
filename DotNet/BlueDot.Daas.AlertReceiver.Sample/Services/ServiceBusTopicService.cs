using Azure.Messaging.ServiceBus;
using BlueDot.Daas.AlertReceiver.Sample.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace BlueDot.Daas.AlertReceiver.Sample.Services
{
    /// <summary>
    /// Generic service to handle configured service bus topic
    /// </summary>
    /// <seealso href="https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-performance-improvements?tabs=net-standard-sdk-2#reusing-factories-and-clients">Best Practices</seealso>
    public class ServiceBusTopicService: IServiceBusTopicService
    {
        private readonly IConfiguration _configuration;

        public ServiceBusTopicService(IConfiguration configuration)
        {
            _configuration = configuration;//TODO strong typed settings
        }

        /// <summary>
        /// Send a text message to the configured service bus topic
        /// </summary>
        /// <param name="messageBody"></param>
        /// <returns></returns>
        public Task SendMessageToTopicAsync(string messageBody)
        {
            var sender = this.ServiceBusClient.CreateSender(_configuration["DaasNotificationServiceBus:Topic"]);
            return sender.SendMessageAsync(new ServiceBusMessage(messageBody));
        }

        public Task<ServiceBusProcessor> GetServiceBusProcessorAsync(Func<ProcessMessageEventArgs, Task> MessageHandler,
           Func<ProcessErrorEventArgs, Task> ErrorHandler)
        {
            // create a processor that we can use to process the messages
            ServiceBusProcessor processor = ServiceBusClient.CreateProcessor(_configuration["DaasNotificationServiceBus:Topic"], _configuration["DaasNotificationServiceBus:Subscription"], new ServiceBusProcessorOptions());

            // add handler to process messages
            processor.ProcessMessageAsync += MessageHandler;

            // add handler to process any errors
            processor.ProcessErrorAsync += ErrorHandler;

            return Task.FromResult(processor);
        }

        private ServiceBusClient _serviceBusClient;
        private ServiceBusClient ServiceBusClient
        {
            get
            {
                if (_serviceBusClient == default || _serviceBusClient.IsClosed)
                {
                    _serviceBusClient = new ServiceBusClient(_configuration["DaasNotificationServiceBus:ConnectionString"]);
                }
                return _serviceBusClient;
            }
        }
    }
}
