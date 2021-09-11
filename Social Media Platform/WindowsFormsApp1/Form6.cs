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
    public partial class NearbyForm : Form
    {
        private MySqlConnection databaseConnection;
        string username, user_address;
        int userID; 
        public NearbyForm(string user, int ID)
        {
            username = user;
            userID = ID;
            InitializeComponent();
        }

        private void post_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void NearbyForm_Load(object sender, EventArgs e)
        {

            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;" +
                   "password=;database=social_1000104492";

            databaseConnection = new MySqlConnection(MySQLConnectionString);

            try
            {
                databaseConnection.Open();
                string query3 = "SET AUTOCOMMIT = 0; " +
                   "START TRANSACTION;" +
                   "CALL getAddress('"+ this.username +"');" +
                   "COMMIT;" +
                   "SET AUTOCOMMIT = 1;";


                MySqlCommand cmd = new MySqlCommand(query3, databaseConnection);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    //failed 
                    MessageBox.Show("No address");
                }
                else
                {
                    // sucess
                    while (dr.Read())
                    {
                        user_address = Convert.ToString(dr["address"]);
                        address_label.Text = user_address;
                        address_label.Visible = true;
                    }
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


            user_label.Text = username;
            user_label.Visible = true;

            
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

        private void Load_Data()
        {
            if (databaseConnection.State == ConnectionState.Closed)
            {
                databaseConnection.Open();
            }


            
            string query3 = "SET AUTOCOMMIT = 0; " +
                             "START TRANSACTION;" +
                             "SELECT users.username, nearToMe(users.address, '"+ this.user_address + "') AS NEARBY FROM users WHERE users.username != '"+ this.username +"' GROUP BY users.id;" +
                             "COMMIT;" +
                             "SET AUTOCOMMIT = 1;";



            MySqlCommand cmd = new MySqlCommand(query3, databaseConnection);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            dataGridView1.ReadOnly = true;
        }
    }
}
