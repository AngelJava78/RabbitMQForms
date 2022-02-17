using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitMQForms
{
    public partial class SubscriberForm : Form
    {
        Subscriber subscriber;
        IModel model;
        public SubscriberForm()
        {
            InitializeComponent();
        }

        private void subscribeButton_Click(object sender, EventArgs e)
        {
            var queueName = queueComboBox.Text;
            subscriber = new Subscriber(queueName);
            model = subscriber.Subscribe(queueName);
            subscribeButton.Enabled = false;
            unsubscribeButton.Enabled = true;
            var consumer = new AsyncEventingBasicConsumer(model);
            consumer.Received += Consumer_Received;
            model.BasicConsume(queueName, false, consumer);
        }

        private async Task Consumer_Received(object sender, BasicDeliverEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Body.ToArray());
            message += Environment.NewLine;
            messagesTextBox.Invoke((MethodInvoker)(() => messagesTextBox.AppendText(message)));
            model.BasicAck(e.DeliveryTag, false);

        }

        private void unsubscribeButton_Click(object sender, EventArgs e)
        {
            model = null;
            subscriber = null;

            subscribeButton.Enabled = true;
            unsubscribeButton.Enabled = false;
        }


    }
}
