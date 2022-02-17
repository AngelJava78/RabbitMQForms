
namespace RabbitMQForms
{
    partial class PublisherForm
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.emailButton = new System.Windows.Forms.Button();
            this.smsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(13, 13);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(67, 20);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Message";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(13, 37);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(775, 387);
            this.messageTextBox.TabIndex = 1;
            // 
            // emailButton
            // 
            this.emailButton.Location = new System.Drawing.Point(537, 430);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(122, 29);
            this.emailButton.TabIndex = 2;
            this.emailButton.Text = "Publish Email";
            this.emailButton.UseVisualStyleBackColor = true;
            this.emailButton.Click += new System.EventHandler(this.emailButton_Click);
            // 
            // smsButton
            // 
            this.smsButton.Location = new System.Drawing.Point(665, 430);
            this.smsButton.Name = "smsButton";
            this.smsButton.Size = new System.Drawing.Size(122, 29);
            this.smsButton.TabIndex = 5;
            this.smsButton.Text = "Publish Sms";
            this.smsButton.UseVisualStyleBackColor = true;
            this.smsButton.Click += new System.EventHandler(this.smsButton_Click);
            // 
            // PublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.smsButton);
            this.Controls.Add(this.emailButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.messageLabel);
            this.Name = "PublisherForm";
            this.Text = "PublisherForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button emailButton;
        private System.Windows.Forms.Button smsButton;
    }
}