using System.Text;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;


namespace AwesomeSocialMedia.Newsfeed.API.Comsumers
{
    public class UserUpdateConsumer : BackgroundService
    {
        private readonly IModel _channel;
        private const string Queue = "newsfeed.user-updated";
        private const string Exchange = "user";	
        private const string RoutingKey = "user-updated";
        public UserUpdateConsumer()
        {
            //Configuring with rabbitmq
            var connectionFactory = new ConnectionFactory
            {
                HostName = "localhost"
            };

            var connection = connectionFactory.CreateConnection("newsfeed.user-updated");

            _channel = connection.CreateModel();

            //Ensure that Exchange and Queue are created, and bind them together.
            _channel.QueueDeclare(Queue, true, false, false, null);

            _channel.ExchangeDeclare("post", "direct", true, false);

            _channel.QueueBind(Queue, Exchange, RoutingKey);


        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var consumer = new EventingBasicConsumer(_channel);

            consumer.Received += async (sender, eventArgs) => 
            {
                var contentArray = eventArgs.Body.ToArray();
                var json = Encoding.UTF8.GetString(contentArray);

                //Convert the event using JsonCovert.deserializeobject<T>

                _channel.BasicAck(eventArgs.DeliveryTag, false);
            };

            _channel.BasicConsume(Queue, false, consumer);

            return Task.CompletedTask;
        }
    }
}