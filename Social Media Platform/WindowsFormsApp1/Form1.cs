using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        LoginForm login_form = new LoginForm();
        RegisterForm register_form = new RegisterForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            login_form.Visible = true;  

            
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            register_form.Visible = true;
        }
    }
}
