using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using OGEP.Views;
using OGEP.Views.Dialogs;

namespace OGEP
{
    public partial class StudentsList : MetroFramework.Forms.MetroForm
    {
        private List<MetroButton> buttons= new List<MetroButton>();

        public StudentsList()
        {
            InitializeComponent();
        }

        private void StudentsList_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'oGEPdataSet.students_info'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.students_infoTableAdapter.Fill(this.oGEPdataSet.students_info);

            initButtonsList();
            timer1.Start();
            setButtonsEnabled(true);

        }

        private void initButtonsList()
        {
            buttons.Add(editBtn);
            buttons.Add(DeleteBtn);
            buttons.Add(PaimentsButton);
            buttons.Add(ModulesBtn);
        }

      

        private void studentsDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            setButtonsEnabled(true);
        }

        private void setButtonsEnabled(bool v)
        {
            Console.WriteLine("setButtonsEnabled :" + v);
           foreach(MetroButton btn in buttons)
            {
                btn.Enabled = v;
            }
        }



        private void FinishBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddStud ast = new AddStud(this);
            ast.ShowDialog();
        }
        public void RefreshGrid()
        {
            Console.WriteLine("updating sah");
            if (students_infoTableAdapter != null)
            {
               // students_infoTableAdapter.Update((Data.OGEPdataSet.StudentsDataTable)oGEPdataSet.Tables["Students"]);
                this.students_infoTableAdapter.Fill(this.oGEPdataSet.students_info);
            }
            studentsDataGridView.Update();
        }
        private void editBtn_Click(object sender, EventArgs e)
        {


            if (studentsDataGridView.SelectedRows.Count > 1)
                MessageBox.Show("Selectionner un seul etudiant");
            else
            {
               DataGridViewRow s= studentsDataGridView.SelectedRows[0];
                DataGridViewCell c = s.Cells[0];
             //   Student stud = c.Value;
                int studentId = Int32.Parse(s.Cells[0].Value.ToString());
                Console.WriteLine(s.Cells[0].Value.ToString());
                EditStud es = new EditStud(this);
                es.studentId = studentId;
              es.ShowDialog();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Voulez vous vraiment supprimer cet élève?\n"+
                "Cette action est irriversible, voulez vous continuer ? ",
                                                 "Confirmer Suppression",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                deleteSelectedStudent();            }
            else
            {
                // If 'No', do something here.
            }
        }

        private void deleteSelectedStudent()
        {
            studentsinfoBindingSource.RemoveCurrent();
        }

        private void ModulesBtn_Click(object sender, EventArgs e)
        {
        }

        private void PaimentsButton_Click(object sender, EventArgs e)
        {

            if (studentsDataGridView.SelectedRows.Count > 1)
                MessageBox.Show("Selectionner un seul etudiant");
            else
            {
                DataGridViewRow s = studentsDataGridView.SelectedRows[0];
                DataGridViewCell c = s.Cells[0];
                //   Student stud = c.Value;
                int studentId = Int32.Parse(s.Cells[0].Value.ToString());
                string studName = s.Cells[1].Value.ToString();
                string studFamilyName = s.Cells[2].Value.ToString();

                //   Console.WriteLine(s.Cells[0].Value.ToString());
                studPaiments sp = new studPaiments(studentId,studName,studFamilyName);
               if (sp.hasData)
                    sp.ShowDialog();
               else
              sp.Close();
            }
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i = studentsinfoBindingSource.Count;
            if(i>1)
            studentsNbr.Text = "Nombre d'élèves : "+ i +" élèves";
            else
                studentsNbr.Text = "Nombre d'élèves : " + i + " élève";
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchBox.Text))
            {
                this.students_infoTableAdapter.Fill(this.oGEPdataSet.students_info); }
            else
            {
                try
                {
                  this.students_infoTableAdapter.search(this.oGEPdataSet.students_info, SearchBox.Text);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void studentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
