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
    public partial class EditStud : MetroFramework.Forms.MetroForm
    {
        public int studentId { get; set; }


        String connString = OGEP.Objects.dbConst.connectionString;

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        private StudentsList studentsList;

        public EditStud()
        {
            InitializeComponent();
        }

        public EditStud(StudentsList studentsList)
        {
            InitializeComponent();
            this.studentsList = studentsList;
        }

        private void EditStud_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'oGEPdbds.Niveaux'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.niveauxTableAdapter.Fill(this.oGEPdbds.Niveaux);
           initConnectionString();
            loadStudentData();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (studentsList != null)
                ((StudentsList)studentsList).RefreshGrid();
                
                    }

        private void initConnectionString()
        {
            try
            {
                conn.ConnectionString = connString;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Close();
            }
        }



        private void loadStudentData()
        {
            string selectStudentsReq = "select * from students where Id =" + studentId;
            try
            {
                ds.Clear();

                da.SelectCommand = new SqlCommand(selectStudentsReq, conn);
                da.Fill(ds, "student");
                dt = ds.Tables["student"];


                foreach (DataRow dr in dt.Rows)
                {
                    NomTb.Text = dr["Name"].ToString();
                    PrenomTb.Text = dr["FamilyName"].ToString();
                    AdresseTb.Text = dr["Adresse"].ToString();
                    TelTb.Text = dr["Phone"].ToString();
                    TelAlterTb.Text = dr["AlterPhone"].ToString();
                    String niveau = dr["Niveau"].ToString();
                    NiveauCb.SelectedIndex = Int32.Parse(niveau) ;
                    break;
                }
              
            }
            catch (Exception e){
                Console.WriteLine(e.GetBaseException());

            }

        }
     

        private bool validateForm()
        {
            bool valid = true;
            if (NomTb.Text.Length < 3)
            {
                NomTb.CustomBackground = true;
                NomTb.BackColor = Color.LightSalmon;
                valid = false;
            }
            if (PrenomTb.Text.Length < 3)
            {
                PrenomTb.CustomBackground = true;
                PrenomTb.BackColor = Color.LightSalmon;
                valid = false;
            }
            if (AdresseTb.Text.Length < 3)
            {
                AdresseTb.CustomBackground = true;
                AdresseTb.BackColor = Color.LightSalmon;
                valid = false;
            }

            if (TelTb.Text.Length < 9)
            {
                TelTb.CustomBackground = true;
                TelTb.BackColor = Color.LightSalmon;
                valid = false;
            }
            if (TelAlterTb.Text.Length < 9)
            {
                TelAlterTb.CustomBackground = true;
                TelAlterTb.BackColor = Color.LightSalmon;
                valid = false;
            }
            if (!(NiveauCb.SelectedIndex > -1))
            {
                NivLabel.CustomBackground = true;
                NivLabel.BackColor = Color.LightSalmon; valid = false;
            }
            return valid;

        }

        private void updateStudent()
        {
            Console.WriteLine("updateStudent");
            string cmdString = "UPDATE [dbo].[Students] " +
                "set " +
                "Name = @Name, " +
                "FamilyName= @FamilyName," +
                "Adresse= @Adresse," +
                "Phone= @Phone," +
                "AlterPhone = @AlterPhone," +
                "Niveau = @Niveau "+
                "where"+ 
                "(Id  = "+studentId+
                ");";
            cmd.Connection = conn;
            cmd.CommandText = cmdString;
            cmd.Parameters.AddWithValue("@Name", PrenomTb.Text);
            cmd.Parameters.AddWithValue("@FamilyName", NomTb.Text);
            cmd.Parameters.AddWithValue("@Adresse", AdresseTb.Text);
            cmd.Parameters.AddWithValue("@Phone", TelTb.Text);

            cmd.Parameters.AddWithValue("@AlterPhone", TelAlterTb.Text);

            //MessageBox.Show(""+(int)NiveauCb.SelectedValue+1);

            int niveau = ((int)NiveauCb.SelectedValue);//Int32.Parse(selected);
                                                           // MessageBox.Show(""+niveau);

            cmd.Parameters.AddWithValue("@Niveau", niveau);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Cancel();
                conn.Close();
                MessageBox.Show("Mis a jour!");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("error occured");
            }
            Close();
        }

        private void confirmBtn_Click_1(object sender, EventArgs e)
        {
            if (validateForm())
                updateStudent();
        }
    }

}
