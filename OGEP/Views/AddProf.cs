using OGEP.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OGEP.Views
{
    public partial class AddProf : MetroFramework.Forms.MetroForm

    {

        //initialize all classes
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //declaring variables

        string connString = dbConst.connectionString;
        private List<Module> profModules=new List<Module>();
        private ProfsList profsList;

        public AddProf()
        {
            InitializeComponent();
        }

        public AddProf(ProfsList profsList)
        {
            this.profsList = profsList;
                 InitializeComponent();

        }

        private void AddProf_Load(object sender, EventArgs e)
        {
            this.matieresTableAdapter.Fill(this.oGEPdataSet.Matieres);
            this.niveauxTableAdapter.Fill(this.oGEPdataSet.Niveaux);

            initConnectionString();

        }
        private void initConnectionString()
        {
            try
            {
                conn.ConnectionString = connString;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Close();
            }
        }
        private void BtnAddModule_Click(object sender, EventArgs e)
        {
            int matiereId, niveauId;

            matiereId = Int32.Parse(matierescb.SelectedValue.ToString());
            niveauId = Int32.Parse(niveauxcb.SelectedValue.ToString());

            Module module = new Module(matiereId, niveauId);
            if (!isModuleInList(module)) { 
            this.profModules.Add(module);

            string niveaudesi = niveauxcb.GetItemText(niveauxcb.SelectedItem);
            string matieredesi = matierescb.GetItemText(matierescb.SelectedItem);


            listView1.Items.Add(new ListViewItem(matieredesi+" | "+ niveaudesi));
            }
            else { MessageBox.Show("vous avez deja ajouter le meme module"); }
        }
        private bool isModuleInList(Module module)
        {
            for(int i = 0; i < profModules.Count; i++)
            {
                if (profModules[i].matiereId == module.matiereId
                    && 
                    profModules[i].niveauId == module.niveauId)
                    return true;
            }
                return false;
        }


        private bool validateForm()
        {
            bool valid = true;
            if (NomTb.Text.Length < 3)
            {
                NomTb.CustomBackground = true;
                NomTb.BackColor = Color.LightSalmon;
                valid = false;
            }
            if (PrenomTb.Text.Length < 3)
            {
                PrenomTb.CustomBackground = true;
                PrenomTb.BackColor = Color.LightSalmon;
                valid = false;
            }
            if (AdresseTb.Text.Length < 3)
            {
                AdresseTb.CustomBackground = true;
                AdresseTb.BackColor = Color.LightSalmon;
                valid = false;
            }

            if (TelTb.Text.Length < 9)
            {
                TelTb.CustomBackground = true;
                TelTb.BackColor = Color.LightSalmon;
                valid = false;
            }
            if (pourcentagetb.Text.Length < 1)
            {
                pourcentagetb.CustomBackground = true;
                pourcentagetb.BackColor = Color.LightSalmon;
                valid = false;
            }

            return valid;

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (validateForm())
                addToDatabase();
        }
        private void addToDatabase()
        {
            string cmdString = dbConst.addProf;
            DateTime today = DateTime.Today;
            string date = today.ToShortDateString();
            int monthly;

            if (monthRb.Checked)
                monthly = 1;
            else
                monthly = 0;

            cmd.Connection = conn;
            cmd.CommandText = cmdString;
            cmd.Parameters.AddWithValue("@Name", PrenomTb.Text);
            cmd.Parameters.AddWithValue("@FamilyName", NomTb.Text);
            cmd.Parameters.AddWithValue("@Adresse", AdresseTb.Text);
            cmd.Parameters.AddWithValue("@Phone", TelTb.Text);
            cmd.Parameters.AddWithValue("@userId", UserSession.userId);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@monthly", monthly);
            cmd.Parameters.AddWithValue("@prixNormal", prixNrml.Text);
            cmd.Parameters.AddWithValue("@prixVip",prixVip.Text);
            cmd.Parameters.AddWithValue("@percent", pourcentagetb.Text);
            cmd.Parameters.AddWithValue("@other", autreInfo.Text);

            try
            {
                conn.Open();
                AddProfModulesToDb( Convert.ToInt32(cmd.ExecuteScalar()));
              //  cmd.ExecuteNonQuery();
                cmd.Cancel();
                MessageBox.Show("Prof Ajouté!");
                
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                //MessageBox.Show("error occured");
                MessageBox.Show(e.ToString());
            }


            Close();
        }

        private void AddProfModulesToDb(int profId)
        {
            try
            {
                foreach (Module module in profModules)
                {
                    conn.Close();
                    conn.Open();
                    cmd = new SqlCommand(dbConst.addModule,conn);
                    cmd.Parameters.AddWithValue("@profId",  profId);
                    cmd.Parameters.AddWithValue("@userId",  UserSession.userId);
                    cmd.Parameters.AddWithValue("@date",  DateTime.Today.ToShortDateString());
                    cmd.Parameters.AddWithValue("@matiere",  module.matiereId);
                    cmd.Parameters.AddWithValue("@niveau" ,module.niveauId);
                    addOneGroup(Convert.ToInt32(cmd.ExecuteScalar()));
                    cmd.Cancel();
                    cmd.Dispose();
                }
                conn.Close();
                if(profsList!=null)
                    profsList.RefreshGrid();
            }
            catch(Exception E)
            {
                MessageBox.Show(E.ToString());
            }
    }

        private void addOneGroup(int moduleId)
        {
            try
            {
                    conn.Close();
                    conn.Open();
                    cmd = new SqlCommand(dbConst.addGroup, conn);

                cmd.Parameters.AddWithValue("@moduleId", moduleId);
                cmd.Parameters.AddWithValue("@groupName", "A");
                cmd.Parameters.AddWithValue("@userId", UserSession.userId);
                cmd.Parameters.AddWithValue("@date", DateTime.Today.ToShortDateString());
       
                cmd.ExecuteNonQuery();

                cmd.Cancel();
                cmd.Dispose();
                conn.Close();

                Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void nonmonthChecked(object sender, EventArgs e)
        {
            if(!monthRb.Checked)
                nonmonthRb.Checked = true;
        }

        private void MonthChecked(object sender, EventArgs e)
        {
            if (!nonmonthRb.Checked)
                monthRb.Checked = true;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

 
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem )sender).Text == "supprimer")
            {
                MessageBox.Show(profModules.Count+"");
                profModules.RemoveAt(listView1.SelectedItems[0].Index);
                listView1.SelectedItems[0].Remove();
                MessageBox.Show(profModules.Count + "");
            }
        }
    }
}
