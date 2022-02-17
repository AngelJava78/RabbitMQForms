using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQForms
{
    public class Subscriber
    {
        private IConnection rabbitMQConnection;
        readonly string exchangeName;
        readonly string exchangeType;
        readonly bool durable;
        readonly bool autoDelete;
        private string queueName;
        private IModel model;
        public Subscriber(string queueName)
        {
            exchangeName = Configuration.GetInstance().ExchangeName;
            exchangeType = ExchangeType.Direct;
            durable = true;
            autoDelete = false;
            this.queueName = queueName;
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
                queueName = channel.QueueDeclare("").QueueName;
            }
        }

        private void CreateQueues()
        {
            using (var channel = rabbitMQConnection.CreateModel())
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

        public IModel Subscribe(string routingKey)
        {
            model = rabbitMQConnection.CreateModel();
            model.BasicQos(0, 1, false);
            return model;
        }

    }
}
