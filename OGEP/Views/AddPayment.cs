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
    public partial class AddPayment : MetroFramework.Forms.MetroForm 
    {
        //initialize all classes
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //declaring variables

        String connString = OGEP.Objects.dbConst.connectionString;

        private int studentId;
        private studPaiments studPaiments;
        private bool modulesExist;
        private string studentFamilyName;
        private string studentName;
        private SelectStudent selectStudent;


        public AddPayment(int studentId, string studentFamilyName, string studentName, studPaiments studPaiments)
        {
            this.studentId = studentId;
            this.studentFamilyName = studentFamilyName;
            this.studentName = studentName;
            this.studPaiments = studPaiments;
            InitializeComponent();
        }

        public AddPayment(int studentId, string studentFamilyName, string studentName)
        {
            this.studentId = studentId;
            this.studentFamilyName = studentFamilyName;
            this.studentName = studentName;
            InitializeComponent();

        }

        private void AddPayment_Load(object sender, EventArgs e)
        {
            initConnectionString();
            loadStudInfo();
        }

        private void loadStudInfo()
        {
            if (studentId == 0)
            {
                Console.WriteLine("stud id = "+studentId);

                selectStudentPromp();
            }
            else
            {
                Console.WriteLine("loadStudInfo()");
                FamilyNameLabel.Text = studentFamilyName;
                PrenomLabel.Text = studentName;
                StudNumLabel.Text = ""+studentId;
                getUserModules();
            }
        }

        private bool validate()
        { bool valid = true;
            if (!modulesExist) {
                noModulesForUserPrompt();
                valid = false;
            }
            Double i = 0;
            try {i= Double.Parse(MontantTb.Text); } catch { }
            if ( i<50)
            {
                MontantTb.CustomBackground = true;
                MontantTb.BackColor = Color.LightSalmon;
                valid = false;
            }
            if (!(ModuleCB.SelectedIndex > -1))
            {
                ModuleCB.BackColor = Color.LightSalmon;
                valid = false;
            }
            return valid;

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

        private void addToDatabase()
        {
            int moduleId = 1;//((int)ModuleCB.SelectedValue);
            DateTime today = DateTime.Today;

            string date = today.ToShortDateString();
            string cmdString = "INSERT INTO [StudPayment] "+
                "([StudId],[Montant],[Date],[ModuleId])"+
                " VALUES "+
                "(@StudId, @montant, @date, @moduleId)";
            cmd.Connection = conn;
            cmd.CommandText = cmdString;
            cmd.Parameters.AddWithValue("@StudId", studentId);
            cmd.Parameters.AddWithValue("@montant", MontantTb.Text);
            cmd.Parameters.AddWithValue("@ModuleId", moduleId);
            cmd.Parameters.AddWithValue("@date", date);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Cancel();
                conn.Close();
                if (studPaiments != null)

                    studPaiments.RefreshGrid();

               // MessageBox.Show("Added");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("error occured");
            }


            Close();
        }

        private void getUserModules()
        {
            Console.WriteLine("getUserModules()");


            string selectModulesReq = "SELECT"+
                "[Matieres].[Id], " +
                "[Name], " +
                "[FamilyName], " +
                "[Matieres].[Description] " +
                "from " +
                "[Modules], " +
                "[StudModule], "+
                "[Matieres], " +
                "[Profs] " +
                "where( " +
                "StudModule.StudentId =  " +studentId+
                " and " +
                "Modules.Id = StudModule.ModuleId " + 
                "and " +
                "Modules.Matiere = Matieres.Id " +
                "and " +
                "Modules.ProfId = Profs.Id);";



            da.SelectCommand = new SqlCommand(@selectModulesReq, conn);
            ds.Clear();
            da.Fill(ds, "Modules");
            dt = ds.Tables["Modules"];

            foreach (DataRow dr in dt.Rows)
            {
                String ModuleId = dr["Id"].ToString();
                String moduleName = dr["Description"].ToString();
                String profname = dr["FamilyName"].ToString() +
                    " " + dr["Name"].ToString();
                ;
                ComboboxItem item = new ComboboxItem();
                item.Text = moduleName + "| " + profname;
                item.Value = ModuleId;

                ModuleCB.Items.Add(item);
            }
            if (ModuleCB.Items.Count > 0)
            {
                modulesExist = true;
                ModuleCB.Enabled = true;
                ModuleCB.SelectedIndex = 0;
            }
            else
            {
                clearModulesComboBox();
                modulesExist = false;
            }
        }

        private void noModulesForUserPrompt()
        {
            MessageBox.Show("l'élève selectioné n'est inscris dans aucune matiere!");
            Close();
        }

        private void clearModulesComboBox()
        {
            ModuleCB.Items.Clear();
            ModuleCB.SelectedIndex = -1;
            ModuleCB.SelectedText = "Pas de modules pour ce niveau!";
            ModuleCB.SelectedValue = 0;
            ModuleCB.Enabled = false;
        }

        private void selectStudentPromp()
        {
            //Todo
           // throw new NotImplementedException();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (validate())
                addToDatabase();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
