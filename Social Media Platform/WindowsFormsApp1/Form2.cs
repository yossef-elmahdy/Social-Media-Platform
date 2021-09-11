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
    public partial class LoginForm : Form
    {
        private MySqlConnection databaseConnection;
        string username;
        int userID; 
        public LoginForm()
        {
            InitializeComponent();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {

            this.Visible = false;
           
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;" +
                    "password=;database=social_1000104492";

                databaseConnection = new MySqlConnection(MySQLConnectionString);
                databaseConnection.Open();

               
                //string query = "SELECT * FROM users WHERE username='" + user_textBox.Text + "' AND password='" + pass_textBox.Text + "'";
                //string query2 = "CALL login('"+user_textBox.Text+"', '"+pass_textBox.Text+"')";
                string query3 = "SET AUTOCOMMIT = 0; " +
                    "START TRANSACTION;" +
                    "CALL login('" + user_textBox.Text + "', '" + pass_textBox.Text + "');" +
                    "COMMIT;" +
                    "SET AUTOCOMMIT = 1;";


                MySqlCommand cmd = new MySqlCommand(query3, databaseConnection);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    //failed 
                    MessageBox.Show("Authentication Failed!");
                }
                else
                {
                    // sucess
                    while (dr.Read())
                    {
                        username = user_textBox.Text;
                        userID = Convert.ToInt32(dr["id"]);
                    }
                    MessageBox.Show("User: " + username + "   UserID: " + userID);
                    pass_textBox.Clear();
                    user_textBox.Clear();
                    this.Visible = false;
                    HomeForm home_form = new HomeForm(username, userID);
                    home_form.Visible = true;
                }
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }

            
        }
    }
}
