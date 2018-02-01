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
    public partial class SelectStudent : MetroFramework.Forms.MetroForm
    {
        public SelectStudent()
        {
            InitializeComponent();
        }

        private void SelectStudent_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'oGEPdataSet.Students'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.studentsTableAdapter.Fill(this.oGEPdataSet.Students);
            if(oGEPdataSet.Students.Columns.Count < 1)
            {
                MessageBox.Show("il n'y a aucun éléve inscris, veuillez ajouter des élèves!");
                Close();
            }


        }

        private void metroTextBox1_TextCahnged(object sender, EventArgs e)
        {
            try
            {
               // this.studentsTableAdapter.SearchStudent(this.oGEPdataSet.Students, searchBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (studentsDataGridView.SelectedRows.Count > 1)
                MessageBox.Show("Selectionner un seul etudiant");
            else
            {
                if (studentsDataGridView.SelectedRows.Count == 0)
                    MessageBox.Show("Selectionner un etudiant !");
                else
                {
                    DataGridViewRow s = studentsDataGridView.SelectedRows[0];
                    DataGridViewCell c = s.Cells[0];
                    //   Student stud = c.Value;
                    int studentId = Int32.Parse(s.Cells[0].Value.ToString());
                    Console.WriteLine(s.Cells[0].Value.ToString());
                    string studentFamilyName = s.Cells[1].Value.ToString();
                    string studentName = s.Cells[2].Value.ToString();
                    AddPayment es = new AddPayment(studentId, studentFamilyName, studentName);
                    es.Show();
                    Close();
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
