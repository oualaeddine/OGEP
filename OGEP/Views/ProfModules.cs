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
    public partial class ProfModules : MetroFramework.Forms.MetroForm
    {
        String connString = OGEP.Objects.dbConst.connectionString;

        SqlConnection connection;
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();

        public bool hasData { get; set; }
        public string StudentName { get; private set; }
        public string StudentFamilyName { get; private set; }
        private int profId;

        public ProfModules()
        {
            InitializeComponent();
        }

        public ProfModules(int profId,string ProfName,string ProfFamilyName)
        {
            this.profId = profId;

            this.StudentName = ProfName;
            this.StudentFamilyName = ProfFamilyName;
            this.hasData = true;
            if (getData())
                InitializeComponent();
        }

        private void ProfModules_Load(object sender, EventArgs e)
        {
            fillGridView();
            NumLabel.Text = "" + profId;
            PrenomLabel.Text = StudentName;
            NomLabel.Text = StudentFamilyName;
        }

        private bool getData()
        {
            string cmdString = "SELECT DISTINCT " +
                " [Modules].[Id], "+
                " [Matieres].[Description] as [matiere], "+
                " [Niveaux].[Description] as [niveau], "+
                " [Modules].[date] "+
                " from "+
                " [Modules], "+
                " [Niveaux], "+
                " [Matieres] "+
                " where( "+
                " [modules].ProfId = "+profId+
                " and "+
                " [modules].[year] = [niveaux].[Id] "+
                " and "+
                " [modules].[Matiere] = [Matieres].[Id]"+     
                " );";

        connection = new SqlConnection(connString);
            try
            {
                connection.Open();
                adapter = new SqlDataAdapter(cmdString, connection);

                adapter.Fill(ds);
                connection.Close();
                if (ds.Tables[0].Rows.Count < 1)
                {
                    var confirmResult = MessageBox.Show("Cet enseignant n'a pas de modules!", "Pas de Modules", MessageBoxButtons.OK);
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

        private void fillGridView()
        {
            profModulesGridView.DataSource = null;

            profModulesGridView.DataSource = ds.Tables[0];
            profModulesGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

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

        public void RefreshGrid()
        {
            profModulesGridView.DataSource = null;
            ds.Clear();
            getData();
            fillGridView();
        }

      

        private void profModulesGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = profModulesGridView.HitTest(e.X, e.Y).RowIndex;
            //    m.Show(profModulesGridView, new Point(e.X, e.Y));
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modifierGroupesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           int moduleId = Int32.Parse(profModulesGridView.SelectedRows[0].Cells[0].Value.ToString());
            string matiere = profModulesGridView.SelectedRows[0].Cells[1].Value.ToString();
            string niveau = profModulesGridView.SelectedRows[0].Cells[1].Value.ToString();
            new ModuleGroups(moduleId, matiere, niveau,  StudentFamilyName+ " " + StudentName).ShowDialog();
        }
    }
}
