using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using OGEP;
using OGEP.Properties;
using OGEP.Objects;

namespace OGEP
{
    public partial class AddStud : MetroFramework.Forms.MetroForm
    {
        //initialize all classes
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //declaring variables

        String connString = OGEP.Objects.dbConst.connectionString;
        internal StudentsList creator;
        private List<Objects.Module> listeDesModules=new List<Objects.Module>();

        public AddStud(StudentsList creatorInstance)
        {
            creator = creatorInstance;
            InitializeComponent();
        }

        public AddStud()
        {
            InitializeComponent();

        }

        private void AddStud_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'oGEPdbds.Students'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.studentsTableAdapter.Fill(this.oGEPdbds.Students);
            // TODO: cette ligne de code charge les données dans la table 'oGEPdbds1.StudModule'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.niveauxTableAdapter.Fill(this.oGEPdbds.Niveaux);
            if(NiveauCb.Items.Count<1)
            {
                MessageBox.Show("ajouter des nivaux en premier depuis la fenetre parametres, l'onglet Matieres et niveaux");
                new Views.Settings().Show();
                this.Hide();
            }
            initConnectionString();
            NiveauCb.SelectedIndexChanged += new System.EventHandler(NiveauCb_SelectedIndexChanged);
            ModulesList.View = View.List;
            // These are optional
            ModulesList.GridLines = true;
            ModulesList.FullRowSelect = true;

            this.ModulesList.Columns.Add(new ColumnHeader());
            this.ModulesList.Columns[0].Text = "Liste des inscriptions";
            this.ModulesList.Columns[0].Width = 350;


            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);

        }

        private void initConnectionString()
        {
            try
            {
                conn.ConnectionString = connString;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                Close();
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (validateForm())
                addToDatabase();
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
            if (AdresseTb.Text.Length< 3)
            {
                AdresseTb.CustomBackground = true;
                AdresseTb.BackColor = Color.LightSalmon;
                valid = false;
            }

            if (TelTb.Text.Length< 9)
            {
                TelTb.CustomBackground = true;
                TelTb.BackColor = Color.LightSalmon;
                valid = false;
            }
            if (TelAlterTb.Text.Length < 9)
            {
                TelAlterTb.CustomBackground = true;
                TelAlterTb.BackColor = Color.LightSalmon;
                valid = false;
            }
            if (!(NiveauCb.SelectedIndex > -1))
            {
                NivLabel.CustomBackground = true;
                NivLabel.BackColor = Color.LightSalmon; valid = false; }
            return valid;

        }

        private void addToDatabase()
        {
            string cmdString = Objects.dbConst.addStud;
            DateTime today = DateTime.Today;
            string date = today.ToShortDateString();

            cmd.Connection = conn;
            cmd.CommandText = cmdString;
            cmd.Parameters.AddWithValue("@Name", PrenomTb.Text);
            cmd.Parameters.AddWithValue("@FamilyName", NomTb.Text);
            cmd.Parameters.AddWithValue("@Adresse", AdresseTb.Text);
            cmd.Parameters.AddWithValue("@Phone", TelTb.Text);
            cmd.Parameters.AddWithValue("@AlterPhone", TelTb.Text);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@userId", UserSession.userId);

            //MessageBox.Show(""+(int)NiveauCb.SelectedValue+1);

            int niveau = ((int)NiveauCb.SelectedValue );//Int32.Parse(selected);
           // MessageBox.Show(""+niveau);

            cmd.Parameters.AddWithValue("@Niveau", niveau);

            try
            {
                conn.Open();
                AddStudModulesToDb(Convert.ToInt32(cmd.ExecuteScalar()));
                cmd.Cancel();
                conn.Close();
                MessageBox.Show("Added");
            }   catch(SqlException e)
            {
                Console.WriteLine(e.ToString());  
                MessageBox.Show("error occured");
            }

            Close();
        }

        private void AddStudModulesToDb(int studId)
        {
            /** "(@studId, @moduleId, @userId)" **/

            try
            {
                foreach (Objects.Module module in listeDesModules)
                {
                    conn.Close();
                    conn.Open();
                    cmd = new SqlCommand(dbConst.addStudModule, conn);
                    cmd.Parameters.AddWithValue("@userId", UserSession.userId);
                    cmd.Parameters.AddWithValue("@date", DateTime.Today.ToShortDateString());
                    cmd.Parameters.AddWithValue("@moduleId", module.moduleId);
                    cmd.Parameters.AddWithValue("@studId", studId);
                    cmd.ExecuteNonQuery();
                    cmd.Cancel();
                    cmd.Dispose();
                }
                conn.Close();
                if (creator != null)
                    creator.RefreshGrid();
                Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateGridIfExists();
        }


        private void updateGridIfExists()
        {
            if(creator!=null)
            {
                 creator.RefreshGrid();
                Console.WriteLine("updating");
            }
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void NewModuleCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("");

        }

        private void NiveauCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearModulesComboBox();

            int IdNiveau = 0; 
            try
            {
                IdNiveau = ((int)NiveauCb.SelectedValue);//Int32.Parse(selected);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            string selectModulesReq = "SELECT [Name] as profName," +
                "[FamilyName] as ProfFamilyName," +
                "[Matieres].[Description]," +
                "[Matieres].[Id]"+
                "from"+
                "[Modules],"+
                "[Matieres],"+
                "[Profs]" +
                "where("+
                "[Modules].[year]= " + IdNiveau +
                "and " +
                "[Modules].[Matiere] = [Matieres].[Id] " +
                "and " +
                "[Modules].[ProfId] = [Profs].[Id]);";


            da.SelectCommand = new SqlCommand(@selectModulesReq, conn);
            ds.Clear();
            da.Fill(ds, "Modules");
            dt = ds.Tables["Modules"];
            
            foreach (DataRow dr in dt.Rows)
            {
                String ModuleId = dr["Description"].ToString();
                String moduleName = dr["Description"].ToString();
                String profname = dr["ProfFamilyName"].ToString() + " " + dr["profName"].ToString();
                
                ComboboxItem item = new ComboboxItem();
                item.Text = moduleName + "| " + profname;
                item.Value  = ModuleId;
            
                NewModuleCb.Items.Add(item);
            }

            if (NewModuleCb.Items.Count > 0)
            {
                NewModuleCb.Enabled = true;
                NewModuleCb.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("there is no modules in this lvl");
                clearModulesComboBox();
            }
        }

        private void clearModulesComboBox()
        {
            NewModuleCb.Items.Clear();
            NewModuleCb.SelectedIndex = -1;
            NewModuleCb.SelectedText = "Pas de modules pour ce niveau!";
            NewModuleCb.SelectedValue = 0;
            NewModuleCb.Enabled = false;

        }

        private void BtnAddModule_Click(object sender, EventArgs e)
        {
            if (ModulesList.Items.Count > 0)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ((ComboboxItem)NewModuleCb.SelectedItem).Text;
                ModulesList.Items.Add(item);
                listeDesModules.Add(new Objects.Module(Int32.Parse(((ComboboxItem)NewModuleCb.SelectedItem).Value.ToString())));
            }
        }

        private void ModulesList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (ModulesList.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }


        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Text == "supprimer")
            {
                MessageBox.Show(listeDesModules.Count + "");
                listeDesModules.RemoveAt(ModulesList.SelectedItems[0].Index);
                ModulesList.SelectedItems[0].Remove();
                MessageBox.Show(listeDesModules.Count + "");
            }
        }
    }
}
