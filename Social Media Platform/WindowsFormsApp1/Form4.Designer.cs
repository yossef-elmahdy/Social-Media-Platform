
namespace WindowsFormsApp1
{
    partial class HomeForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.logout_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.user_label = new System.Windows.Forms.Label();
            this.post_button = new System.Windows.Forms.Button();
            this.post_richTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.seacrh_text = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.chats_button = new System.Windows.Forms.Button();
            this.nearby_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(881, 409);
            this.dataGridView1.TabIndex = 0;
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(770, 659);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(107, 46);
            this.logout_button.TabIndex = 1;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username: ";
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_label.Location = new System.Drawing.Point(151, 23);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(73, 24);
            this.user_label.TabIndex = 3;
            this.user_label.Text = "Hidden";
            this.user_label.Visible = false;
            // 
            // post_button
            // 
            this.post_button.Location = new System.Drawing.Point(425, 525);
            this.post_button.Name = "post_button";
            this.post_button.Size = new System.Drawing.Size(157, 46);
            this.post_button.TabIndex = 4;
            this.post_button.Text = "Post";
            this.post_button.UseVisualStyleBackColor = true;
            this.post_button.Click += new System.EventHandler(this.post_button_Click);
            // 
            // post_richTextBox
            // 
            this.post_richTextBox.Location = new System.Drawing.Point(31, 497);
            this.post_richTextBox.Name = "post_richTextBox";
            this.post_richTextBox.Size = new System.Drawing.Size(363, 194);
            this.post_richTextBox.TabIndex = 5;
            this.post_richTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search User: ";
            // 
            // seacrh_text
            // 
            this.seacrh_text.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seacrh_text.Location = new System.Drawing.Point(530, 23);
            this.seacrh_text.Name = "seacrh_text";
            this.seacrh_text.Size = new System.Drawing.Size(207, 28);
            this.seacrh_text.TabIndex = 7;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(743, 23);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(64, 28);
            this.search_button.TabIndex = 8;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(770, 497);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(107, 46);
            this.delete_button.TabIndex = 9;
            this.delete_button.Text = "Delete Post";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(425, 626);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(157, 46);
            this.update_button.TabIndex = 10;
            this.update_button.Text = "Update Post";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // chats_button
            // 
            this.chats_button.Location = new System.Drawing.Point(248, 24);
            this.chats_button.Name = "chats_button";
            this.chats_button.Size = new System.Drawing.Size(64, 28);
            this.chats_button.TabIndex = 11;
            this.chats_button.Text = "Chats";
            this.chats_button.UseVisualStyleBackColor = true;
            this.chats_button.Click += new System.EventHandler(this.chats_button_Click);
            // 
            // nearby_button
            // 
            this.nearby_button.Location = new System.Drawing.Point(813, 24);
            this.nearby_button.Name = "nearby_button";
            this.nearby_button.Size = new System.Drawing.Size(64, 28);
            this.nearby_button.TabIndex = 12;
            this.nearby_button.Text = "Nearby";
            this.nearby_button.UseVisualStyleBackColor = true;
            this.nearby_button.Click += new System.EventHandler(this.nearby_button_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 717);
            this.Controls.Add(this.nearby_button);
            this.Controls.Add(this.chats_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.seacrh_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.post_richTextBox);
            this.Controls.Add(this.post_button);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Button post_button;
        private System.Windows.Forms.RichTextBox post_richTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox seacrh_text;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button chats_button;
        private System.Windows.Forms.Button nearby_button;
    }
}