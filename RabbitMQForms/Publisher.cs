using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace RabbitMQForms
{
    public class Publisher
    {

        private IConnection rabbitMQConnection;
        readonly string exchangeName;
        readonly string exchangeType;
        readonly bool durable;
        readonly bool autoDelete;

        public Publisher()
        {
            exchangeName = Configuration.GetInstance().ExchangeName;
            exchangeType = ExchangeType.Direct;
            durable = true;
            autoDelete = false;
            Connect();
            CreateExchange(exchangeName, exchangeType, durable, autoDelete);
            CreateQueues();
            BindQueues();
        }

        private void Connect()
        {
            var connectionString = Configuration.GetInstance().RabbitMQConnectionString;
            var connectionFactory = new ConnectionFactory()
            {
                Uri = new Uri(connectionString),
                AutomaticRecoveryEnabled = true,
                DispatchConsumersAsync = true,

            };
            rabbitMQConnection = connectionFactory.CreateConnection();
        }

        private void CreateExchange(string exchangeName, string exchangeType, bool durable, bool autoDelete)
        {
            using (var channel = rabbitMQConnection.CreateModel())
            {
                channel.ExchangeDeclare(exchangeName, exchangeType, durable, autoDelete);
            }
        }

        private void CreateQueues()
        {
            using(var channel = rabbitMQConnection.CreateModel())
            {
                channel.QueueDeclare("Email", true, false, false);
                channel.QueueDeclare("Sms", true, false, false);
            }
        }

        private void BindQueues()
        {
            using (var channel = rabbitMQConnection.CreateModel())
            {
                channel.QueueBind("Email", exchangeName, "email");
                channel.QueueBind("Sms", exchangeName, "sms");
            }
        }
        public void Send(string routingKey, string message)
        {
            using(var channel = rabbitMQConnection.CreateModel())
            {
                var body = Encoding.UTF8.GetBytes(message);
                var properties = channel.CreateBasicProperties();
                properties.DeliveryMode = 2;
                channel.BasicPublish(exchangeName, routingKey, properties, body);
            }
        }
    }
}
