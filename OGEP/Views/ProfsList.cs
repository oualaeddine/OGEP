using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DGVPrinterHelper;


namespace OGEP.Views
{
    public partial class ProfsList : MetroFramework.Forms.MetroForm
    {
        private List<MetroButton> buttons = new List<MetroButton>();

        public ProfsList()
        {
            InitializeComponent();
        }

        private void ProfsList_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'oGEPdataSet.profs_info'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.profs_infoTableAdapter.Fill(this.oGEPdataSet.profs_info);
            // TODO: cette ligne de code charge les données dans la table 'oGEPdataSet.Profs'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            initButtonsList();
            timer1.Start();
        }

        private void initButtonsList()
        {
            buttons.Add(editBtn);
            buttons.Add(DeleteBtn);
            buttons.Add(PaimentsButton);
            buttons.Add(ModulesBtn);
        }


        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
               // this.profs_infoTableAdapter.SearchProf1(this.oGEPdataSet.Profs, SearchBox.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void profsDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            setButtonsEnabled(true);
        }

        private void setButtonsEnabled(bool v)
        {
            Console.WriteLine("setButtonsEnabled :" + v);
            foreach (MetroButton btn in buttons)
            {
                btn.Enabled = v;
            }
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            AddProf ast = new AddProf(this);
            ast.ShowDialog();
        }

        public void RefreshGrid()
        {
            if (profs_infoTableAdapter != null)
            {
               // profs_infoTableAdapter.Update((Data.OGEPdataSet.profs_infoDataTable)oGEPdataSet.Tables["profs_info"]);
                this.profs_infoTableAdapter.Fill(this.oGEPdataSet.profs_info);
            }
            profsDataGridView.Update();
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (profsDataGridView.SelectedRows.Count > 1)
                MessageBox.Show("Selectionner un seul enseignant");
            else
            {
                DataGridViewRow s = profsDataGridView.SelectedRows[0];
                DataGridViewCell c = s.Cells[0];
                //   Student stud = c.Value;
                int studentId = Int32.Parse(s.Cells[0].Value.ToString());
                Console.WriteLine(s.Cells[0].Value.ToString());
               /* EditStud es = new EditStud(this);
                es.studentId = studentId;
                es.ShowDialog();*/
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Voulez vous vraiment supprimer cet ensignant?\n" +
                "Cette action est irriversible, voulez vous continuer ? ",
                                                 "Confirmer Suppression",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                deleteSelectedStudent();
            }
            else
            {
                // If 'No', do something here.
            }
        }

        private void deleteSelectedStudent()
        {
            profsinfoBindingSource1.RemoveCurrent();
        }

        private void PaimentsButton_Click(object sender, EventArgs e)
        {
            if (profsDataGridView.SelectedRows.Count > 1)
                MessageBox.Show("Selectionner un seul etudiant");
            else
            {
                DataGridViewRow s = profsDataGridView.SelectedRows[0];
                DataGridViewCell c = s.Cells[0];
                //   Student stud = c.Value;
                int studentId = Int32.Parse(s.Cells[0].Value.ToString());
                string studName = s.Cells[1].Value.ToString();
                string studFamilyName = s.Cells[2].Value.ToString();

                //   Console.WriteLine(s.Cells[0].Value.ToString());
              /*  ProfPaiments sp = new ProfPaiments(studentId, studName, studFamilyName);
                if (sp.hasData)
                    sp.ShowDialog();
                else
                    sp.Close();*/
            }
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i = profsinfoBindingSource1.Count;
            if (i > 1)
                studentsNbr.Text = "Nombre de profs : " + i + " profs";
            else
                studentsNbr.Text = "Nombre de profs : " + i + " prof";
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModulesBtn_Click(object sender, EventArgs e)
        {
            if (profsDataGridView.SelectedRows.Count > 1 || profsDataGridView.SelectedRows.Count==0)
                MessageBox.Show("Veuillez Selectionnez un seul enseignant");
            else
            {
                DataGridViewRow s = profsDataGridView.SelectedRows[0];
                DataGridViewCell c = s.Cells[0];
                //   Student stud = c.Value;
                int profId = Int32.Parse(s.Cells[0].Value.ToString());
                string ProfName = s.Cells[1].Value.ToString();
                string profFamilyName = s.Cells[2].Value.ToString();

                Console.WriteLine(s.Cells[0].Value.ToString());
                new ProfModules(profId,ProfName,profFamilyName).ShowDialog();

            }

        }
    /*    public static void Print(DataGridView dgv)
        {
            DGVPrinter printer = new DGVPrinter();
           
            printer.Title = "Profs List";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "OGEP";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dgv);
        }*/
        private void profsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
          //  Print(profsDataGridView);
        }
    }
}
