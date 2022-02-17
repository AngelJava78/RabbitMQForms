
namespace RabbitMQForms
{
    partial class SubscriberForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.unsubscribeButton = new System.Windows.Forms.Button();
            this.subscribeButton = new System.Windows.Forms.Button();
            this.messagesTextBox = new System.Windows.Forms.TextBox();
            this.messagesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.queueComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // unsubscribeButton
            // 
            this.unsubscribeButton.Location = new System.Drawing.Point(665, 12);
            this.unsubscribeButton.Name = "unsubscribeButton";
            this.unsubscribeButton.Size = new System.Drawing.Size(122, 29);
            this.unsubscribeButton.TabIndex = 9;
            this.unsubscribeButton.Text = "Unsubscribe";
            this.unsubscribeButton.UseVisualStyleBackColor = true;
            this.unsubscribeButton.Click += new System.EventHandler(this.unsubscribeButton_Click);
            // 
            // subscribeButton
            // 
            this.subscribeButton.Location = new System.Drawing.Point(537, 12);
            this.subscribeButton.Name = "subscribeButton";
            this.subscribeButton.Size = new System.Drawing.Size(122, 29);
            this.subscribeButton.TabIndex = 8;
            this.subscribeButton.Text = "Subscribe";
            this.subscribeButton.UseVisualStyleBackColor = true;
            this.subscribeButton.Click += new System.EventHandler(this.subscribeButton_Click);
            // 
            // messagesTextBox
            // 
            this.messagesTextBox.Location = new System.Drawing.Point(12, 82);
            this.messagesTextBox.Multiline = true;
            this.messagesTextBox.Name = "messagesTextBox";
            this.messagesTextBox.Size = new System.Drawing.Size(775, 387);
            this.messagesTextBox.TabIndex = 7;
            // 
            // messagesLabel
            // 
            this.messagesLabel.AutoSize = true;
            this.messagesLabel.Location = new System.Drawing.Point(12, 58);
            this.messagesLabel.Name = "messagesLabel";
            this.messagesLabel.Size = new System.Drawing.Size(73, 20);
            this.messagesLabel.TabIndex = 6;
            this.messagesLabel.Text = "Messages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Queue name:";
            // 
            // queueComboBox
            // 
            this.queueComboBox.FormattingEnabled = true;
            this.queueComboBox.Items.AddRange(new object[] {
            "Email",
            "Sms"});
            this.queueComboBox.Location = new System.Drawing.Point(114, 13);
            this.queueComboBox.Name = "queueComboBox";
            this.queueComboBox.Size = new System.Drawing.Size(202, 28);
            this.queueComboBox.TabIndex = 11;
            // 
            // SubscriberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 544);
            this.Controls.Add(this.queueComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unsubscribeButton);
            this.Controls.Add(this.subscribeButton);
            this.Controls.Add(this.messagesTextBox);
            this.Controls.Add(this.messagesLabel);
            this.Name = "SubscriberForm";
            this.Text = "SubscriberForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button unsubscribeButton;
        private System.Windows.Forms.Button subscribeButton;
        private System.Windows.Forms.TextBox messagesTextBox;
        private System.Windows.Forms.Label messagesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox queueComboBox;
    }
}