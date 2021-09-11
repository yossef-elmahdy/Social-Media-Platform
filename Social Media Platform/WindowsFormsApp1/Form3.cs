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
    public partial class RegisterForm : Form
    {
        private MySqlConnection databaseConnection;
        public RegisterForm()
        {
            InitializeComponent();
        }

        int id = 6;

        private void Form3_Load(object sender, EventArgs e)
        {
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;" +
                    "password=;database=social_1000104492";

            try
            {
                databaseConnection = new MySqlConnection(MySQLConnectionString);
                databaseConnection.Open();

                //string query = "SELECT name FROM genders";
                //string query2 = "CALL getGenders();";
                string query3 = "SET AUTOCOMMIT = 0; " +
                                 "START TRANSACTION;" +
                                 "CALL getGenders();" +
                                 "COMMIT;" +
                                 "SET AUTOCOMMIT = 1;";


                MySqlCommand cmd = new MySqlCommand(query3, databaseConnection);
                MySqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    gender.Items.Add(dr["name"]);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
            

            
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(first_name.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(username.Text)
                || string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("You MUST fill the required fields");
                fname_label.Text = "*First Name";
                email_label.Text = "*Email";
                pass_label.Text = "*Password";
                username_label.Text = "*Username";

                fname_label.ForeColor = Color.IndianRed;
                email_label.ForeColor = Color.IndianRed;
                pass_label.ForeColor = Color.IndianRed;
                username_label.ForeColor = Color.IndianRed; 
                
            }
            else
            {
                try
                {
                    databaseConnection.Open();

                    //BASIC
                     /*string insert = "INSERT INTO users VALUES ("+ id++ +", '"+first_name.Text+"', '"+last_name.Text+"'," +
                         " '"+username.Text+"', '"+email.Text+"', '"+password.Text+"', '"+dateTimePicker1.Value.ToString("yyyy-MM-dd")+"', "+ (gender.SelectedIndex+1) +"," +
                         " '"+address.Text+"', '"+bio.Text+ "', CURRENT_TIMESTAMP)";*/

                    //USING STORED PROCEDURES
                    /*string insert2 = "CALL register (" + id++ + ", '" + first_name.Text + "', '" + last_name.Text + "'," +
                        " '" + username.Text + "', '" + email.Text + "', '" + password.Text + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', " + (gender.SelectedIndex + 1) + "," +
                        " '" + address.Text + "', '" + bio.Text + "')";*/

                    //USING TRANSACTIONS
                    string insert3 = "SET AUTOCOMMIT = 0; " +
                                     "START TRANSACTION;" +
                                     "CALL register (" + id++ + ", '" + first_name.Text + "', '" + last_name.Text + "'," +
                                    " '" + username.Text + "', '" + email.Text + "', '" + password.Text + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', " + (gender.SelectedIndex + 1) + "," +
                                    " '" + address.Text + "', '" + bio.Text + "');" +
                                     "COMMIT;" +
                                     "SET AUTOCOMMIT = 1;";


                    MySqlCommand cmd = new MySqlCommand(insert3, databaseConnection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successful Registration");

                    first_name.Clear();
                    last_name.Clear();
                    username.Clear();
                    password.Clear();
                    email.Clear();
                    bio.Clear();
                    address.Clear();
                    gender.SelectedIndex = -1;

                    fname_label.Text = "First Name";
                    email_label.Text = "Email";
                    pass_label.Text = "Password";
                    username_label.Text = "Username";

                    fname_label.ForeColor = Color.Black;
                    email_label.ForeColor = Color.Black;
                    pass_label.ForeColor = Color.Black;
                    username_label.ForeColor = Color.Black;




                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
                finally
                {
                    databaseConnection.Close();
                }
            }
              
          
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
