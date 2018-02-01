using OGEP.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGEP.Views
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        String connString = dbConst.connectionString;
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public Login()
        {
            InitializeComponent();
        }

        private void initDb()
        {
            string cmdString = "if not exists " +
                          " (select * from UserTypes where descr = 'ADMIN')" +
                          "INSERT INTO [UserTypes] " +
                         "([id],[descr])" +
                         " VALUES " +
                         "(1,@user1),(2,@user2)";
            try
            {
                conn.ConnectionString = connString;
                cmd.Connection = conn;
            }catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show(e.ToString());
            }
            cmd.CommandText = cmdString;
            cmd.Parameters.AddWithValue("@user1", "ADMIN");
            cmd.Parameters.AddWithValue("@user2", "USER");
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Cancel();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show(e.ToString());
            }

            string cmdString2 = "if not exists " +
                " (select * from Users where username = 'ADMIN') " +
                "INSERT INTO [Users] " +
                         "([userName],[password], [type])" +
                         " VALUES " +
                         "(@username,@password,@type),('USER','USER',2)";
            conn.ConnectionString = connString;
            cmd.Connection = conn;
            cmd.CommandText = cmdString2;
            cmd.Parameters.AddWithValue("@username", "ADMIN");
            cmd.Parameters.AddWithValue("@password", "ADMIN");
            cmd.Parameters.AddWithValue("@type", 1);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Cancel();
                conn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show(e.ToString());
                //  Close();
            }
            fillComboBox();
        }

        private void fillComboBox()
        {
            string selectModulesReq = "SELECT * " +
                       "from" +
                       "[Users]";



            da.SelectCommand = new SqlCommand(@selectModulesReq, conn);
            ds.Clear();
            da.Fill(ds, "users");
            dt = ds.Tables["users"];

            foreach (DataRow dr in dt.Rows)
            {
                String id = dr["Id"].ToString();
                String userName = dr["username"].ToString();
                string pass = dr["password"].ToString();
                //MessageBox.Show(userName+" id : "+id+ "  password : "+pass);
                ComboboxItem item = new ComboboxItem();
                item.Text = userName;
                item.Value = id;
                metroComboBox1.DataSource = null;
                metroComboBox1.Items.Add(item);
            }
            metroComboBox1.SelectedIndex = 0;
            metroComboBox1.SelectedValue = ((ComboboxItem)metroComboBox1.Items[0]).Value;
        }

        private void UserControl_Load(object sender, EventArgs e)
        {
            if(usersBindingSource.Count<1)  initDb();
        }

         private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            if (metroComboBox1.SelectedIndex > -1)
            {
                string value = ((ComboboxItem)metroComboBox1.Items[metroComboBox1.SelectedIndex]).Value;
                //      MessageBox.Show(value);
                int userId = Int32.Parse(value);
                if (valid(userId))
                {
                    new Dashboard(this).Show();
                    UserSession.userId = userId;
                    UserSession.username = metroComboBox1.SelectedText.ToString();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Mot de pass incorrect!");
                }
            }
        }

        private bool valid(int userId)
        {
            string cmdString54 = "SELECT COUNT(*) FROM users WHERE (Id= " + userId + " AND password = '" + passwordTb.Text + "');";
            //MessageBox.Show("Login" + userId
            //    + " " + passwordTb.Text);
            SqlConnection conne = new SqlConnection(connString);
            SqlDataAdapter daapt = new SqlDataAdapter(cmdString54, conne);
            DataTable dta = new DataTable();

            dta.Clear();
            daapt.Fill(dta);
            //MessageBox.Show(dta.Rows[0][0].ToString());
            if (dta.Rows[0][0].ToString() == "1")
                return true;
            else
                return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
