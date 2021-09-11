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
    public partial class ChatsForm : Form
    {
        private MySqlConnection databaseConnection;
        string username;
        int userID; 
        public ChatsForm(string User, int ID)
        {
            this.username = User;
            this.userID = ID;
            InitializeComponent();
        }

        private void post_button_Click(object sender, EventArgs e)
        {
            this.Visible = false; 
        }

        private void Load_Data()
        {
            try
            {
                if (databaseConnection.State == ConnectionState.Closed)
                {
                    databaseConnection.Open();
                }

                //string query = "CALL getChatsOf('"+ this.username +"');";
                //string query2 = "CALL getMessages('" + this.userID + "');";
                string query3 = "SET AUTOCOMMIT = 0; " +
                                 "START TRANSACTION;" +
                                 "CALL getMessages('" + this.userID + "');" +
                                 "COMMIT;" +
                                 "SET AUTOCOMMIT = 1;";

                MySqlCommand cmd = new MySqlCommand(query3, databaseConnection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void chats_form_Load(object sender, EventArgs e)
        {
            user_label.Text = username;
            user_label.Visible = true;
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;" +
                   "password=;database=social_1000104492";

            try
            {
                databaseConnection = new MySqlConnection(MySQLConnectionString);

                Load_Data();



                //fill the combobox with the users
                //string query_users = "CALL getUsers('" + this.username + "');";
                string query_users3 = "SET AUTOCOMMIT = 0; " +
                                        "START TRANSACTION;" +
                                        "CALL getUsers('"+ this.username +"');" +
                                        "COMMIT;" +
                                        "SET AUTOCOMMIT = 1;";

                MySqlCommand cmd = new MySqlCommand(query_users3, databaseConnection);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    users_comboBox.Items.Add(dr["username"]);
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

        private void send_button_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(message_richTextBox.Text))
            {
                MessageBox.Show("No message to send"); 
            }
            else
            {
                try
                {
                    databaseConnection.Open();

                    //string query = "CALL send_message('"+ message_richTextBox.Text +"', '"+ this.username +"', '"+ users_comboBox.SelectedItem.ToString() +"');";
                    string query3 = "SET AUTOCOMMIT = 0; " +
                                        "START TRANSACTION;" +
                                       "CALL send_message('"+message_richTextBox.Text +"', '"+ this.username +"', '"+ users_comboBox.SelectedItem.ToString() +"');" +
                                        "COMMIT;" +
                                        "SET AUTOCOMMIT = 1;";

                    MySqlCommand cmd = new MySqlCommand(query3, databaseConnection);
                    cmd.ExecuteNonQuery();

                    Load_Data();

                    message_richTextBox.Clear();
                    users_comboBox.SelectedIndex = -1; 

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            send_button.Enabled = false;

            //string query2 = "CALL countMessages("+ this.userID +");";
            string query3 = "SET AUTOCOMMIT = 0; " +
                             "START TRANSACTION;" +
                             "CALL countMessages("+ this.userID +");" +
                             "COMMIT;" +
                             "SET AUTOCOMMIT = 1;";

            MySqlCommand cmd = new MySqlCommand(query3, databaseConnection);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void messages_button_Click(object sender, EventArgs e)
        {
            send_button.Enabled = true;

            try
            {
                Load_Data();
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
