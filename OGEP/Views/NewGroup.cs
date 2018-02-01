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
    public partial class NewGroup : MetroFramework.Forms.MetroForm
    {
        public NewGroup()
        {
            InitializeComponent();
        }

        private void NewGroup_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'oGEPdataSet.Matieres'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.matieresTableAdapter.Fill(this.oGEPdataSet.Matieres);
            // TODO: cette ligne de code charge les données dans la table 'oGEPdataSet.Niveaux'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.niveauxTableAdapter.Fill(this.oGEPdataSet.Niveaux);

        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
