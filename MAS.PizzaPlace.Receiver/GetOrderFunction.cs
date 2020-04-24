using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace MAS.PizzaPlace.Receiver
{
    public static class GetOrderFunction
    {
        [FunctionName("GetOrderFunction")]
        public static void Run([ServiceBusTrigger("orders", Connection = "ConnectionString")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
