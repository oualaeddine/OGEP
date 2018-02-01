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
    public partial class studPaiments : MetroFramework.Forms.MetroForm
    {
        String connString = OGEP.Objects.dbConst.connectionString;

        SqlConnection connection;
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();

        private  int StudentId;
        public bool hasData { get; set; }
        public string StudentName { get; private set; }
        public string StudentFamilyName { get; private set; }

        public studPaiments(int StudentId,string StudentName,string StudentFamilyName)
        {
            this.StudentId = StudentId;
            this.StudentName = StudentName;
            this.StudentFamilyName = StudentFamilyName;
            this.hasData = true;
            if (getData())
                InitializeComponent();
        }

    
        private bool getData()
        {
            string cmdString = "SELECT DISTINCT " +
            "[StudPayment].[Id] ," +
            //    "[Students].[FamilyName] as [Nom] ," +
            //  "[Students].[Name] as [prenom] ," +
            "[Matieres].[Description] as [matiere] ," +
            "[Profs].[FamilyName] as [Nom Prof] ," +
            "[Profs].[Name] as [prenom Prof] ," +
            "[Niveaux].[Description] as [niveau], " +
            "[StudPayment].[Montant], " +
            "[StudPayment].[Date] " +
            "from " +
            "Niveaux, Profs, Matieres, Students, StudPayment, modules " +
            "where( " +
            "[StudPayment].[StudId] = " + StudentId +
            " and " +
            // "[StudPayment].[StudId] = [Students].[Id] and " +
            "[StudPayment].[ModuleId] = [Modules].[Id] and " +
            "[Modules].[Matiere] = [Matieres].[Id] and " +
            "[Modules].[ProfId] = [Profs].[Id] and " +
            "[Modules].[year] = [Niveaux].[Id] " +
            ");";
            connection = new SqlConnection(connString);
            try
            {
                connection.Open();
                adapter = new SqlDataAdapter(cmdString, connection);
                
                adapter.Fill(ds);
                connection.Close();
                if (ds.Tables[0].Rows.Count < 1)
                {
                    var confirmResult = MessageBox.Show("Cet élève n'a pas de paiments!", "Pas de Paiments", MessageBoxButtons.OK);
                    if (confirmResult == DialogResult.OK)
                    {
                        hasData = false;
                        return false;
                    }
                }
                else
                {
                    hasData = true;
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                hasData = false;
                return false;
            }
            hasData = false;
            return false;
        }

        private void studPaiments_Load(object sender, EventArgs e)
        {
            fillGridView();
            NumLabel.Text = ""+StudentId;
            PrenomLabel.Text = StudentName;
            NomLabel.Text = StudentFamilyName;

        }

        private void fillGridView()
        {
            studPaymentsGridView.DataSource = null;
            
            studPaymentsGridView.DataSource = ds.Tables[0];
            studPaymentsGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

        }
        private bool isLoaded;
        protected override void OnLoad(EventArgs e)
        {
            // the base method raises the load method
            base.OnLoad(e);

            // notify the "Load" method is complete
            this.isLoaded = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // the base method process the painting
            base.OnPaint(e);

            // this method can be theoretically called before the "Load" event is proceeded
            // , therefore is required to check if "isLoaded == true"
            if (this.isLoaded)
            {
                // now are all events hooked to "Load" method proceeded => the form is loaded
                this.OnLoadComplete(e);
            }
        }

        // your "special" method to handle "load is complete" event
        protected virtual void OnLoadComplete(PaintEventArgs e)
        {
            if (!hasData)
                Close();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newPaymentBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("newPaymentBtn_Click Student ID + " + StudentId);
            new AddPayment(StudentId,StudentFamilyName, StudentName, this).ShowDialog();
        }
        public void RefreshGrid()
        {
            studPaymentsGridView.DataSource = null;
            ds.Clear();
            getData();
            fillGridView();
        }
    }
}
