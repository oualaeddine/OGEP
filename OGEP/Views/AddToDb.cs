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
    public partial class AddToDb : MetroFramework.Forms.MetroForm
    {
        private readonly int EDIT = 1,ADD=2;
        private int moduleId;
        private String moduleString;
        private int rC;
        private int type;


        String connString = OGEP.Objects.dbConst.connectionString;

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        private StudentsList studentsList;
        private Settings creator;

        public AddToDb()
        {
            InitializeComponent();
        }

        public AddToDb(int rc, Settings settingsView) 
        {
            this.rC = rc;
            this.type = ADD;
            this.creator = settingsView;
            InitializeComponent();
        }


        public AddToDb(int rc, int moduleId, string moduleString, Settings settingsView) 
        {
            this.creator = settingsView;

            this.moduleString = moduleString;
            this.moduleId = moduleId;
            this.rC = rc;
            this.type = EDIT;
            InitializeComponent();
        }

        private void AddToDb_Load(object sender, EventArgs e)
        {
            initView();

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (validateForm())
                AddDataToDb();
        }

        private void AddDataToDb()
        {
            string cmdString;
            string src = "Matieres";
            if (rC != 1)
                src = "Niveaux";
            Console.WriteLine("soooooooooooooouuuurce :  "+src);

            if (type == ADD)
                cmdString = "INSERT INTO [dbo].[" + src + "] ([Description]) values (@description);";
            else
                cmdString = "UPDATE [dbo].[" + src + "] set [Description] = @description  where Id = "+moduleId+";";
            Console.WriteLine(cmdString);
            Console.WriteLine(src);

            cmd.Connection = conn;
            cmd.CommandText = cmdString;
            cmd.Parameters.AddWithValue("@description", textBox.Text);
            try
            {
                conn.ConnectionString = connString;
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Cancel();
                conn.Close();
                this.creator.refreshTables();
                Close();
                //MessageBox.Show("Mis a jour!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show(e.ToString());
                Close();
            }
        }

        private bool validateForm()
        {
            if (textBox.Text.Length < 1)
                return false;
            return true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void initView()
        {
            if (type == EDIT)
            {
                if (rC == 1)
                    TitleLabel.Text = "Modifier le Module";
                else
                    TitleLabel.Text = "Modifier la Matiere";
                textBox.Text = moduleString;
            }
            else
            {
                if (type == ADD)
                    if (rC == 1)
                        TitleLabel.Text = "Ajouter un Module";
                    else
                        TitleLabel.Text = "Ajouter une Matiere";
            }
        }
    }
}
