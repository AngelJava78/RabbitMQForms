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
    public partial class PublisherForm : Form
    {
        public PublisherForm()
        {
            InitializeComponent();
        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            SendMessage("email");
        }

        private void smsButton_Click(object sender, EventArgs e)
        {
            SendMessage("sms");
        }

        public void SendMessage(string routingKey)
        {
            var message = messageTextBox.Text.Trim();
            messageTextBox.Text = string.Empty;
            var publisher = new Publisher();
            publisher.Send(routingKey, message);
            
        }
    }
}
