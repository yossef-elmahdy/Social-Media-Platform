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
    public partial class HomeForm : Form
    {
        private MySqlConnection databaseConnection;
        string username;
        int userID;
        int post_id = 2;
        ChatsForm chats_form;
        NearbyForm nearby_form;
        
        public HomeForm(string User, int ID)
        {
            username = User;
            userID = ID;
            chats_form = new ChatsForm(this.username, this.userID);
            nearby_form = new NearbyForm(this.username, this.userID);
            InitializeComponent();
        }

        private void Load_Data()
        {
            if (databaseConnection.State == ConnectionState.Closed)
            {
                databaseConnection.Open();
            }

            /*string query = "SELECT posts.context AS POST, users.username AS BY_USER, posts.created_at AS POST_TIME, COUNT(likes.user_id) AS LIKES, COUNT(comments.user_id) as COMMENTS " +
                "FROM posts " +
                "LEFT JOIN likes " +
                "ON posts.id = likes.post_id " +
                "LEFT JOIN comments " +
                "ON posts.id = comments.post_id " +
                "JOIN users " +
                "ON posts.user_id = users.id " +
                "GROUP BY posts.context " +
                "ORDER BY posts.created_at DESC; ";*/
           

            //string query2 = "CALL getPosts();";
            string query3 = "SET AUTOCOMMIT = 0; " +
                             "START TRANSACTION;" +
                             "CALL getPosts();" +
                             "COMMIT;" +
                             "SET AUTOCOMMIT = 1;";



            MySqlCommand cmd = new MySqlCommand(query3, databaseConnection);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {


            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;" +
                    "password=;database=social_1000104492";

            try
            {
                databaseConnection = new MySqlConnection(MySQLConnectionString);

                Load_Data();

                user_label.Text = username;
                user_label.Visible = true;
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

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void post_button_Click(object sender, EventArgs e)
        {
            if (post_richTextBox.TextLength < 1)
            {
                MessageBox.Show("The post is too small");
            }
            else if (post_richTextBox.TextLength > 1000)
            {
                MessageBox.Show("The post is too large");
            }
            else
            {
                try
                {
                    databaseConnection.Open();
                    //string insert = "CALL makePost(" + post_id++ + ", '" + post_richTextBox.Text + "', " + userID + ")";

                    string insert3 = "SET AUTOCOMMIT = 0; " +
                                    "START TRANSACTION;" +
                                    "CALL makePost(" + post_id++ + ", '" + post_richTextBox.Text + "', " + userID + ");" +
                                    "COMMIT;" +
                                    "SET AUTOCOMMIT = 1;";


                    MySqlCommand cmd = new MySqlCommand(insert3, databaseConnection);
                    cmd.ExecuteNonQuery();

                    //sucess
                    MessageBox.Show("Posted successfully!");
                    Load_Data();
                    post_richTextBox.Clear();
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

        private void search_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(seacrh_text.Text))
            {
                try
                {
                    Load_Data();
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
            else if (seacrh_text.TextLength <= 3)
            {
                MessageBox.Show("Can't search by this");
            }
            else
            {
                try
                {
                    databaseConnection.Open();

                    //string query = "CALL search_user('" + seacrh_text.Text + "')";
                    string query3 = "SET AUTOCOMMIT = 0; " +
                                     "START TRANSACTION;" +
                                     "CALL search_user('" + seacrh_text.Text + "');" +
                                     "COMMIT;" +
                                     "SET AUTOCOMMIT = 1;";


                    MySqlCommand cmd = new MySqlCommand(query3, databaseConnection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (!dr.HasRows)
                    {
                        MessageBox.Show("No users are found!");
                    }
                    else
                    {
                        dr.Close(); 
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                        DataSet ds = new DataSet();
                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0].DefaultView;
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
           
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            string context = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string user = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //MessageBox.Show(context + " " + user);

            if (user == username)
            {
                //trying to delete his own post 
                try
                {
                    databaseConnection.Open();
                    //string delete = "CALL delete_post('" + context + "', '" + user + "');";
                    string delete3 = "SET AUTOCOMMIT = 0; " +
                                     "START TRANSACTION;" +
                                     "CALL delete_post('" + context + "', '" + user + "');" +
                                     "COMMIT;" +
                                     "SET AUTOCOMMIT = 1;";


                    MySqlCommand cmd = new MySqlCommand(delete3, databaseConnection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Deleted Successfully!");

                    Load_Data();
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
            else
            {
                MessageBox.Show("Can't delete the post as it belongs to the user: " + user);
            }

           
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            string context = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string user = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            if (user == username)
            {
                if (post_richTextBox.TextLength < 1)
                {
                    MessageBox.Show("The post is too small");
                }
                else if (post_richTextBox.TextLength > 1000)
                {
                    MessageBox.Show("The post is too large");
                }
                else
                {
                    try
                    {
                        databaseConnection.Open();
                        //string update = "CALL update_post('" + post_richTextBox.Text + "', '" + context + "', '" + user + "');";

                        string update3 = "SET AUTOCOMMIT = 0; " +
                                         "START TRANSACTION;" +
                                         "CALL update_post('" + post_richTextBox.Text + "', '" + context + "', '" + user + "');" +
                                         "COMMIT;" +
                                         "SET AUTOCOMMIT = 1;";


                        MySqlCommand cmd = new MySqlCommand(update3, databaseConnection);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Updated Successfully!");

                        post_richTextBox.Clear();

                        Load_Data();
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
            else
            {
                MessageBox.Show("Can't update the post as it belongs to the user: " + user);
            }


        }

        private void chats_button_Click(object sender, EventArgs e)
        {
            chats_form.Visible = true; 
        }

        private void nearby_button_Click(object sender, EventArgs e)
        {
            nearby_form.Visible = true; 
        }
    }
}
