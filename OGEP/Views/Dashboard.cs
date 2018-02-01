using OGEP.Planing;
using OGEP.Views;
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

namespace OGEP
{
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();
       
        }

        public Dashboard(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            // insertNiveaux();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closing);


            // calculerMoney();
        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            this.login.Close();
        }

        private void calculerMoney()
        {
            int abo=0, 
                licences,
                clientsNbr = 20,
                aboPrice = 2*1000,
                licencePrice = 10*1000,
                total;
             

            for (int i = 0;i<=12;i++) 
                abo = +(i * aboPrice * clientsNbr);

            licences = licencePrice * clientsNbr*12;
            total = (licences + abo);

            MessageBox.Show("licences : " + licences +
                "\n abonnements : " + abo + 
                "\n total : " + total);
        }



        //initialize all classes
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //declaring variables

        String connString = OGEP.Objects.dbConst.connectionString;
        private Login login;


        private void addStudImgView_Click(object sender, EventArgs e)
        {
            AddStudTile.PerformClick();
        }

        private void AddStudTv_Click(object sender, EventArgs e)
        {
            AddStudTile.PerformClick();
        }

        private void NewPaimentTv_Click(object sender, EventArgs e)
        {
            NewPaimentTile.PerformClick();
        }

        private void NewPaimentIv_Click(object sender, EventArgs e)
        {
            NewPaimentTile.PerformClick();
        }


        private void PlaningIv_Click(object sender, EventArgs e)
        {
            PlaningTile.PerformClick();
        }

        private void PlaningTv_Click(object sender, EventArgs e)
        {
            PlaningTile.PerformClick();
        }

        private void UnpaidTv_Click(object sender, EventArgs e)
        {
            UnpaidTile.PerformClick();
        }

        private void UnpaidIv_Click(object sender, EventArgs e)
        {
            UnpaidTile.PerformClick();
        }


        private void HistoryTv_Click(object sender, EventArgs e)
        {
            HistoryTile.PerformClick();
        }

        private void SettingsIv_Click(object sender, EventArgs e)
        {
            GroupsTile.PerformClick();
        }

        private void SettingsTv_Click(object sender, EventArgs e)
        {
            GroupsTile.PerformClick();

        }

        private void InfoIv_Click(object sender, EventArgs e)
        {
            PointageTile.PerformClick();

        }

        private void infoTv_Click(object sender, EventArgs e)
        {
            PointageTile.PerformClick();

        }

        private void LprofsTv_Click(object sender, EventArgs e)
        {
            LprofsTile.PerformClick();

        }

        private void LprofsIv_Click(object sender, EventArgs e)
        {
            LprofsTile.PerformClick();

        }


        private void LelevesTv_Click(object sender, EventArgs e)
        {
            LelevesTile.PerformClick();

        }

        private void LelevesIv_Click(object sender, EventArgs e)
        {
            LelevesTile.PerformClick();
        }

        private void AddStudTile_Click(object sender, EventArgs e)
        {
            new AddStud().ShowDialog();
        }
        private void NewPaimentTile_Click(object sender, EventArgs e)
        {
            new SelectStudent().ShowDialog();

        }
        private void PlaningTile_Click(object sender, EventArgs e)
        {
            new PlaningView().ShowDialog();
        }
        private void UnpaidTile_Click(object sender, EventArgs e)
        {

        }
        private void HistoryTile_Click(object sender, EventArgs e)
        {
            new PaymentsHistory().ShowDialog();
        }
        private void SettingTile_Click(object sender, EventArgs e)
        {
            new Groupes().ShowDialog();
        }
        private void LelevesTile_Click(object sender, EventArgs e)
        {
            new StudentsList().ShowDialog();

        }
        private void LprofsTile_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("LprofsTile_Click");
            // new AddProf().ShowDialog();
            new ProfsList().ShowDialog();
        }
        private void InfoTile_Click(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
                AddStudTile.PerformClick();
            if (keyData == (Keys.F2))
                NewPaimentTile.PerformClick();
            if (keyData == (Keys.F3))
                PointageTile.PerformClick();
            if (keyData == (Keys.F4))
                UnpaidTile.PerformClick();
            if (keyData == (Keys.F5))
                HistoryTile.PerformClick();
            if (keyData == (Keys.F6))
                PlaningTile.PerformClick();
            if (keyData == (Keys.F7))
                LelevesTile.PerformClick();
            if (keyData == (Keys.F8))
                LprofsTile.PerformClick();
            if (keyData == (Keys.F9))
                GroupsTile.PerformClick();
            if (keyData == (Keys.F10))
                new Settings().ShowDialog();
            if (keyData == (Keys.F11)) {
                this.Hide();
                login.Show();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Settings().ShowDialog();
        }
        /**
*  pointage
* code barre
* methode de paiment prof
* planning  manuel
* seances sup
* charges profs
* enfants de profs
**/
    }
}
