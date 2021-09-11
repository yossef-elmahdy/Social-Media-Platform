
namespace WindowsFormsApp1
{
    partial class ChatsForm
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
            this.user_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.post_button = new System.Windows.Forms.Button();
            this.message_richTextBox = new System.Windows.Forms.RichTextBox();
            this.send_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.users_comboBox = new System.Windows.Forms.ComboBox();
            this.count_button = new System.Windows.Forms.Button();
            this.messages_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_label.Location = new System.Drawing.Point(310, 35);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(73, 24);
            this.user_label.TabIndex = 5;
            this.user_label.Text = "Hidden";
            this.user_label.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(524, 318);
            this.dataGridView1.TabIndex = 6;
            // 
            // post_button
            // 
            this.post_button.Location = new System.Drawing.Point(445, 493);
            this.post_button.Name = "post_button";
            this.post_button.Size = new System.Drawing.Size(91, 37);
            this.post_button.TabIndex = 7;
            this.post_button.Text = "Close";
            this.post_button.UseVisualStyleBackColor = true;
            this.post_button.Click += new System.EventHandler(this.post_button_Click);
            // 
            // message_richTextBox
            // 
            this.message_richTextBox.Location = new System.Drawing.Point(12, 434);
            this.message_richTextBox.Name = "message_richTextBox";
            this.message_richTextBox.Size = new System.Drawing.Size(292, 96);
            this.message_richTextBox.TabIndex = 8;
            this.message_richTextBox.Text = "";
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(314, 493);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(91, 37);
            this.send_button.TabIndex = 9;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "To";
            // 
            // users_comboBox
            // 
            this.users_comboBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_comboBox.FormattingEnabled = true;
            this.users_comboBox.Location = new System.Drawing.Point(374, 432);
            this.users_comboBox.Name = "users_comboBox";
            this.users_comboBox.Size = new System.Drawing.Size(162, 29);
            this.users_comboBox.TabIndex = 11;
            // 
            // count_button
            // 
            this.count_button.Location = new System.Drawing.Point(417, 47);
            this.count_button.Name = "count_button";
            this.count_button.Size = new System.Drawing.Size(119, 37);
            this.count_button.TabIndex = 12;
            this.count_button.Text = "Count Messages";
            this.count_button.UseVisualStyleBackColor = true;
            this.count_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // messages_button
            // 
            this.messages_button.Location = new System.Drawing.Point(12, 47);
            this.messages_button.Name = "messages_button";
            this.messages_button.Size = new System.Drawing.Size(119, 37);
            this.messages_button.TabIndex = 13;
            this.messages_button.Text = "Messages";
            this.messages_button.UseVisualStyleBackColor = true;
            this.messages_button.Click += new System.EventHandler(this.messages_button_Click);
            // 
            // ChatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 542);
            this.Controls.Add(this.messages_button);
            this.Controls.Add(this.count_button);
            this.Controls.Add(this.users_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.message_richTextBox);
            this.Controls.Add(this.post_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.label1);
            this.Name = "ChatsForm";
            this.Text = "Chats";
            this.Load += new System.EventHandler(this.chats_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button post_button;
        private System.Windows.Forms.RichTextBox message_richTextBox;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox users_comboBox;
        private System.Windows.Forms.Button count_button;
        private System.Windows.Forms.Button messages_button;
    }
}