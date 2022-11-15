using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Options;
using Order.Service.Proxies.Catalog.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Order.Service.Proxies.Catalog
{
  
    public  class CatalogQueueProxy : ICatalogProxy
    {
        private readonly  string _connectionString;

        public CatalogQueueProxy(IOptions<AzureServiceBus> azure)
        {
            _connectionString = azure.Value.ConnectionString;
          
        }
        public async Task UpdateStockAsync(ProductInStockUpdateStockCommand command)
        {
            // using Azure.Messaging.ServiceBus;

            string connectionString = "Endpoint=sb://amareo-queue.servicebus.windows.net/;SharedAccessKeyName=RootManager;SharedAccessKey=C+YhqcmUQ0N9VDcfeC8SkPV4XIwgYWP1nwKEySoRjlA=;EntityPath=order-stock-update";
            string queueName = "order-stock-update";

            // Because ServiceBusClient implements IAsyncDisposable, we'll create it 
            // with "await using" so that it is automatically disposed for us.
            await using var client = new ServiceBusClient(connectionString);

            // The sender is responsible for publishing messages to the queue.
            ServiceBusSender sender = client.CreateSender(queueName);
            string body = JsonSerializer.Serialize(command);
            ServiceBusMessage message = new ServiceBusMessage(Encoding.UTF8.GetBytes(body));

            await sender.SendMessageAsync(message);

            // The receiver is responsible for reading messages from the queue.
            ServiceBusReceiver receiver = client.CreateReceiver(queueName);
            ServiceBusReceivedMessage receivedMessage = await receiver.ReceiveMessageAsync();

        }

    }
}
