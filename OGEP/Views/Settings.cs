using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGEP.Views
{
    public partial class Settings : MetroFramework.Forms.MetroForm
    {
        public int MODULE_RC = 1, NiVEAUX_RC = 2;

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            refreshTables();

        }

        private void addMatiereBtn_Click(object sender, EventArgs e)
        {
            new AddToDb(MODULE_RC,this).ShowDialog();
        }

        private void EditMatiereBtn_Click(object sender, EventArgs e)
        {

            DataGridViewRow s = matieresDataGridView.SelectedRows[0];
            DataGridViewCell c = s.Cells[0];
            int moduleId = Int32.Parse(s.Cells[0].Value.ToString());
            string moduleString = s.Cells[1].Value.ToString();

            MessageBox.Show(moduleId + "   " + moduleString);
            new AddToDb(MODULE_RC,moduleId,moduleString, this).ShowDialog();

        }

        private void deleteMatiereBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Voulez vous vraiment supprimer cette Matiere?\n" +
                    "Cette action est irriversible, voulez vous continuer ? ",
                                                     "Confirmer Suppression",
                                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                deleteSelectedMatiere();
            }
            else
            {
                // If 'No', do something here.
            }
        }

        private void deleteSelectedMatiere()
        {
            matieresBindingSource.RemoveCurrent();
        }

        private void AddNiveauBtn_Click(object sender, EventArgs e)
        {
            new AddToDb(NiVEAUX_RC, this).ShowDialog();
        }

        private void editNiveauBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow s = NiveauxdataGridView.SelectedRows[0];
            DataGridViewCell c = s.Cells[0];
            int moduleId = Int32.Parse(s.Cells[0].Value.ToString());
            string moduleString = s.Cells[1].Value.ToString();

            MessageBox.Show(moduleId + "   " + moduleString);
            new AddToDb(NiVEAUX_RC, moduleId, moduleString, this).ShowDialog();
        }

        private void deleteNiveauBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Voulez vous vraiment supprimer ce Niveau?\n" +
                   "Cette action est irriversible, voulez vous continuer ? ",
                                                    "Confirmer Suppression",
                                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                deleteSelectedNiveau();
            }
            else
            {
                // If 'No', do something here.
            }
        }

        private void deleteSelectedNiveau()
        {
            niveauxBindingSource.RemoveCurrent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void refreshTables()
        {
            // TODO: cette ligne de code charge les données dans la table 'oGEPdataSet.Niveaux'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.niveauxTableAdapter.Fill(this.oGEPdataSet.Niveaux);
            // TODO: cette ligne de code charge les données dans la table 'oGEPdataSet.Matieres'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.matieresTableAdapter.Fill(this.oGEPdataSet.Matieres);
        }
    }
}
