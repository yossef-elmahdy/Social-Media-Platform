
namespace WindowsFormsApp1
{
    partial class RegisterForm
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
            this.fname_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.RichTextBox();
            this.bio = new System.Windows.Forms.RichTextBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cancel_button = new System.Windows.Forms.Button();
            this.register_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_label.Location = new System.Drawing.Point(53, 66);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(119, 24);
            this.fname_label.TabIndex = 1;
            this.fname_label.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(56, 141);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(65, 24);
            this.email_label.TabIndex = 3;
            this.email_label.Text = "Email";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(53, 219);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(112, 24);
            this.username_label.TabIndex = 4;
            this.username_label.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(442, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Birth Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(442, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Bio";
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_label.Location = new System.Drawing.Point(440, 219);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(107, 24);
            this.pass_label.TabIndex = 9;
            this.pass_label.Text = "Password";
            // 
            // first_name
            // 
            this.first_name.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name.Location = new System.Drawing.Point(213, 66);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(180, 28);
            this.first_name.TabIndex = 10;
            // 
            // last_name
            // 
            this.last_name.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name.Location = new System.Drawing.Point(578, 66);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(228, 28);
            this.last_name.TabIndex = 11;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(213, 141);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(593, 28);
            this.email.TabIndex = 12;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(213, 219);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(180, 28);
            this.username.TabIndex = 13;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(578, 219);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(228, 28);
            this.password.TabIndex = 14;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(213, 405);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(180, 96);
            this.address.TabIndex = 15;
            this.address.Text = "";
            // 
            // bio
            // 
            this.bio.Location = new System.Drawing.Point(578, 405);
            this.bio.Name = "bio";
            this.bio.Size = new System.Drawing.Size(228, 96);
            this.bio.TabIndex = 16;
            this.bio.Text = "";
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Location = new System.Drawing.Point(213, 310);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(180, 24);
            this.gender.TabIndex = 17;
            this.gender.SelectedIndexChanged += new System.EventHandler(this.gender_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-mm-dd";
            this.dateTimePicker1.Location = new System.Drawing.Point(578, 319);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 24);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(521, 532);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(181, 45);
            this.cancel_button.TabIndex = 20;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(142, 532);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(181, 45);
            this.register_button.TabIndex = 19;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 598);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.bio);
            this.Controls.Add(this.address);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.email);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fname_label);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.RichTextBox address;
        private System.Windows.Forms.RichTextBox bio;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button register_button;
    }
}