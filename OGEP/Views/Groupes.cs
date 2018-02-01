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
    public partial class Groupes : MetroFramework.Forms.MetroForm
    {
        public Groupes()
        {
            InitializeComponent();
        }

        private void Groupes_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'oGEPdataSet.Students_groups'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.students_groupsTableAdapter.Fill(this.oGEPdataSet.Students_groups);
            // TODO: cette ligne de code charge les données dans la table 'oGEPdataSet.Groups_info'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.groups_infoTableAdapter.Fill(this.oGEPdataSet.Groups_info);
            // TODO: cette ligne de code charge les données dans la table 'oGEPdataSet.Matieres'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.matieresTableAdapter.Fill(this.oGEPdataSet.Matieres);
            // TODO: cette ligne de code charge les données dans la table 'oGEPdataSet.Niveaux'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.niveauxTableAdapter.Fill(this.oGEPdataSet.Niveaux);
            if (getGroups()) fillGroupsGrid();
        }

        private void niveauxCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void matieresCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void profCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupesDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editGroupBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteGroupBtn_Click(object sender, EventArgs e)
        {

        }

        private void addGroupBtn_Click(object sender, EventArgs e)
        {
            new NewGroup().ShowDialog();
        }

        private void editStudGroupBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteStudFromGroupBtn_Click(object sender, EventArgs e)
        {

        }

        private void addStudToGroupBtn_Click(object sender, EventArgs e)
        {

        }

        private void elevesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studSearchBox_Click(object sender, EventArgs e)
        {

        }

        private void planningList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        String connString = OGEP.Objects.dbConst.connectionString;
        public bool hasData { get; set; }

        SqlConnection connection;
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();

        private bool getGroups()
        {
            string cmdString = "SELECT DISTINCT " +
                " [Groups].[Id]," +
                " [matieres].[Description] as matiere," +
                " [Profs].[FamilyName] as Nom_prof," +
                " [Profs].Name as prenom_prof," +
                " [Groups].[name] as [group]" +
                " from" +
                " [Groups]," +
                " [Modules]," +
                " [profs]," +
                " [matieres]," +
                " [Niveaux]" +
                " where" +
                " (" +
                " [Groups].[moduleId] = [Modules].[Id]" +
                " and" +
                " [profs].[Id] = [modules].[profid]" +
                " and" +
                " [modules].[Matiere] = [Matieres].id" +
                " and" +
                " [modules].[year] = Niveaux.Id" +
                " and" +
                " [profs].[Id] = 1" +
                " and" +
                " [modules].[year] = 12" +
                " and" +
                " [modules].[Matiere] = 1" +
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

        private void fillGroupsGrid()
        {
            groupesDatagrid.DataSource = null;

            groupesDatagrid.DataSource = ds.Tables[0];
            groupesDatagrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

        }
        private bool getGroupInfos()
        {
            string cmdString = "SELECT DISTINCT " +
                " [Groups].[Id]," +
                " [matieres].[Description] as matiere," +
                " [Profs].[FamilyName] as Nom_prof," +
                " [Profs].Name as prenom_prof," +
                " [Groups].[name] as [group]" +
                " from" +
                " [Groups]," +
                " [Modules]," +
                " [profs]," +
                " [matieres]," +
                " [Niveaux]" +
                " where" +
                " (" +
                " [Groups].[moduleId] = [Modules].[Id]" +
                " and" +
                " [profs].[Id] = [modules].[profid]" +
                " and" +
                " [modules].[Matiere] = [Matieres].id" +
                " and" +
                " [modules].[year] = Niveaux.Id" +
                " and" +
                " [profs].[Id] = 1" +
                " and" +
                " [modules].[year] = 12" +
                " and" +
                " [modules].[Matiere] = 1" +
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

        private void fillGroupInfoGrid()
        {
            groupesDatagrid.DataSource = null;

            groupesDatagrid.DataSource = ds.Tables[0];
            groupesDatagrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

        }

    }
}
