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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void publisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var publisherForm = new PublisherForm
            {
                MdiParent = this
            };
            publisherForm.Show();
        }

        private void subscriberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var subscriberForm = new SubscriberForm
            {
                MdiParent = this
            };
            subscriberForm.Show();
        }
    }
}
