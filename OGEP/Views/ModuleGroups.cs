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
    public partial class ModuleGroups : MetroFramework.Forms.MetroForm
    {
        private string matiere;
        private int moduleId;
        private string niveau;
        private string profFullName;

        public ModuleGroups()
        {
            InitializeComponent();
        }

        public ModuleGroups(int moduleId, string matiere, string niveau, string profFullName)
        {
            this.moduleId = moduleId;
            this.matiere = matiere;
            this.niveau = niveau;
            this.profFullName = profFullName;
        }

        private void ModuleGroups_Load(object sender, EventArgs e)
        {

        }
    }
}
