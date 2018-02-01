namespace OGEP.Views
{
    partial class AddProf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.pourcentagetb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.prixVip = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.prixNrml = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.autreInfo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.nonmonthRb = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.monthRb = new MetroFramework.Controls.MetroRadioButton();
            this.niveauxcb = new MetroFramework.Controls.MetroComboBox();
            this.niveauxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oGEPdataSet = new OGEP.Data.OGEPdataSet();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.BtnAddModule = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.matierescb = new MetroFramework.Controls.MetroComboBox();
            this.matieresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NivLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.AdresseTb = new MetroFramework.Controls.MetroTextBox();
            this.TelTb = new MetroFramework.Controls.MetroTextBox();
            this.PrenomTb = new MetroFramework.Controls.MetroTextBox();
            this.NomTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.addbtn = new MetroFramework.Controls.MetroButton();
            this.cancelbtn = new MetroFramework.Controls.MetroButton();
            this.niveauxTableAdapter = new OGEP.Data.OGEPdataSetTableAdapters.NiveauxTableAdapter();
            this.modulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modulesTableAdapter = new OGEP.Data.OGEPdataSetTableAdapters.ModulesTableAdapter();
            this.matieresTableAdapter = new OGEP.Data.OGEPdataSetTableAdapters.MatieresTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierLesGroupesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.niveauxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGEPdataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matieresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.pourcentagetb);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.prixVip);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.prixNrml);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.autreInfo);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.nonmonthRb);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.monthRb);
            this.metroPanel1.Controls.Add(this.niveauxcb);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.BtnAddModule);
            this.metroPanel1.Controls.Add(this.listView1);
            this.metroPanel1.Controls.Add(this.matierescb);
            this.metroPanel1.Controls.Add(this.NivLabel);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.AdresseTb);
            this.metroPanel1.Controls.Add(this.TelTb);
            this.metroPanel1.Controls.Add(this.PrenomTb);
            this.metroPanel1.Controls.Add(this.NomTb);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(361, 366);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(338, 93);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(20, 19);
            this.metroLabel11.TabIndex = 55;
            this.metroLabel11.Text = "%";
            // 
            // pourcentagetb
            // 
            this.pourcentagetb.Location = new System.Drawing.Point(256, 89);
            this.pourcentagetb.Name = "pourcentagetb";
            this.pourcentagetb.Size = new System.Drawing.Size(76, 23);
            this.pourcentagetb.TabIndex = 54;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(158, 93);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(85, 19);
            this.metroLabel10.TabIndex = 53;
            this.metroLabel10.Text = "Pourcentage:";
            // 
            // prixVip
            // 
            this.prixVip.Location = new System.Drawing.Point(254, 144);
            this.prixVip.Name = "prixVip";
            this.prixVip.Size = new System.Drawing.Size(100, 23);
            this.prixVip.TabIndex = 52;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(212, 148);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(31, 19);
            this.metroLabel5.TabIndex = 51;
            this.metroLabel5.Text = "VIP:";
            // 
            // prixNrml
            // 
            this.prixNrml.Location = new System.Drawing.Point(87, 145);
            this.prixNrml.Name = "prixNrml";
            this.prixNrml.Size = new System.Drawing.Size(100, 23);
            this.prixNrml.TabIndex = 50;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(4, 148);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(77, 19);
            this.metroLabel9.TabIndex = 49;
            this.metroLabel9.Text = "Prix seance:";
            // 
            // autreInfo
            // 
            this.autreInfo.Location = new System.Drawing.Point(4, 318);
            this.autreInfo.Multiline = true;
            this.autreInfo.Name = "autreInfo";
            this.autreInfo.Size = new System.Drawing.Size(350, 45);
            this.autreInfo.TabIndex = 46;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(4, 296);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(184, 19);
            this.metroLabel7.TabIndex = 45;
            this.metroLabel7.Text = "Informations supplementaires:";
            // 
            // nonmonthRb
            // 
            this.nonmonthRb.AutoSize = true;
            this.nonmonthRb.Location = new System.Drawing.Point(212, 127);
            this.nonmonthRb.Name = "nonmonthRb";
            this.nonmonthRb.Size = new System.Drawing.Size(79, 15);
            this.nonmonthRb.TabIndex = 44;
            this.nonmonthRb.Text = "par seance";
            this.nonmonthRb.UseVisualStyleBackColor = true;
            this.nonmonthRb.CheckedChanged += new System.EventHandler(this.nonmonthChecked);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 123);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(110, 19);
            this.metroLabel6.TabIndex = 43;
            this.metroLabel6.Text = "Type de paiment:";
            // 
            // monthRb
            // 
            this.monthRb.AutoSize = true;
            this.monthRb.Checked = true;
            this.monthRb.Location = new System.Drawing.Point(119, 127);
            this.monthRb.Name = "monthRb";
            this.monthRb.Size = new System.Drawing.Size(68, 15);
            this.monthRb.TabIndex = 42;
            this.monthRb.TabStop = true;
            this.monthRb.Text = "mensuel";
            this.monthRb.UseVisualStyleBackColor = true;
            this.monthRb.CheckedChanged += new System.EventHandler(this.MonthChecked);
            // 
            // niveauxcb
            // 
            this.niveauxcb.DataSource = this.niveauxBindingSource;
            this.niveauxcb.DisplayMember = "Description";
            this.niveauxcb.FontSize = MetroFramework.MetroLinkSize.Small;
            this.niveauxcb.FormattingEnabled = true;
            this.niveauxcb.ItemHeight = 19;
            this.niveauxcb.Location = new System.Drawing.Point(49, 178);
            this.niveauxcb.Name = "niveauxcb";
            this.niveauxcb.Size = new System.Drawing.Size(90, 25);
            this.niveauxcb.Style = MetroFramework.MetroColorStyle.Blue;
            this.niveauxcb.TabIndex = 25;
            this.niveauxcb.ValueMember = "Id";
            // 
            // niveauxBindingSource
            // 
            this.niveauxBindingSource.DataMember = "Niveaux";
            this.niveauxBindingSource.DataSource = this.oGEPdataSet;
            // 
            // oGEPdataSet
            // 
            this.oGEPdataSet.DataSetName = "OGEPdataSet";
            this.oGEPdataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(145, 181);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(61, 19);
            this.metroLabel8.TabIndex = 18;
            this.metroLabel8.Text = "Matiere :";
            // 
            // BtnAddModule
            // 
            this.BtnAddModule.BackgroundImage = global::OGEP.Properties.Resources.add_1;
            this.BtnAddModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddModule.Location = new System.Drawing.Point(329, 178);
            this.BtnAddModule.Name = "BtnAddModule";
            this.BtnAddModule.Size = new System.Drawing.Size(25, 25);
            this.BtnAddModule.TabIndex = 40;
            this.BtnAddModule.UseVisualStyleBackColor = true;
            this.BtnAddModule.Click += new System.EventHandler(this.BtnAddModule_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(3, 209);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(355, 84);
            this.listView1.TabIndex = 39;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Liste des modules";
            this.columnHeader1.Width = 351;
            // 
            // matierescb
            // 
            this.matierescb.DataSource = this.matieresBindingSource;
            this.matierescb.DisplayMember = "Description";
            this.matierescb.FontSize = MetroFramework.MetroLinkSize.Small;
            this.matierescb.FormattingEnabled = true;
            this.matierescb.ItemHeight = 19;
            this.matierescb.Location = new System.Drawing.Point(212, 178);
            this.matierescb.Name = "matierescb";
            this.matierescb.Size = new System.Drawing.Size(111, 25);
            this.matierescb.Style = MetroFramework.MetroColorStyle.Blue;
            this.matierescb.TabIndex = 24;
            this.matierescb.ValueMember = "Id";
            // 
            // matieresBindingSource
            // 
            this.matieresBindingSource.DataMember = "Matieres";
            this.matieresBindingSource.DataSource = this.oGEPdataSet;
            // 
            // NivLabel
            // 
            this.NivLabel.AutoSize = true;
            this.NivLabel.Location = new System.Drawing.Point(4, 181);
            this.NivLabel.Name = "NivLabel";
            this.NivLabel.Size = new System.Drawing.Size(39, 19);
            this.NivLabel.TabIndex = 15;
            this.NivLabel.Text = "Niv : ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(4, 93);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "N°Tel :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 55);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Adresse : ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(176, 17);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Prenom : ";
            // 
            // AdresseTb
            // 
            this.AdresseTb.Location = new System.Drawing.Point(76, 51);
            this.AdresseTb.Name = "AdresseTb";
            this.AdresseTb.Size = new System.Drawing.Size(280, 23);
            this.AdresseTb.TabIndex = 2;
            // 
            // TelTb
            // 
            this.TelTb.Location = new System.Drawing.Point(56, 89);
            this.TelTb.Name = "TelTb";
            this.TelTb.Size = new System.Drawing.Size(96, 23);
            this.TelTb.TabIndex = 3;
            // 
            // PrenomTb
            // 
            this.PrenomTb.Location = new System.Drawing.Point(256, 13);
            this.PrenomTb.Name = "PrenomTb";
            this.PrenomTb.Size = new System.Drawing.Size(100, 23);
            this.PrenomTb.TabIndex = 1;
            // 
            // NomTb
            // 
            this.NomTb.Location = new System.Drawing.Point(59, 13);
            this.NomTb.Name = "NomTb";
            this.NomTb.Size = new System.Drawing.Size(100, 23);
            this.NomTb.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nom : ";
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(310, 435);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "Ajouter";
            this.addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(229, 435);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 3;
            this.cancelbtn.Text = "Annuler";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // niveauxTableAdapter
            // 
            this.niveauxTableAdapter.ClearBeforeFill = true;
            // 
            // modulesBindingSource
            // 
            this.modulesBindingSource.DataMember = "Modules";
            this.modulesBindingSource.DataSource = this.oGEPdataSet;
            // 
            // modulesTableAdapter
            // 
            this.modulesTableAdapter.ClearBeforeFill = true;
            // 
            // matieresTableAdapter
            // 
            this.matieresTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem,
            this.modifierLesGroupesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 48);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.supprimerToolStripMenuItem.Text = "supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // modifierLesGroupesToolStripMenuItem
            // 
            this.modifierLesGroupesToolStripMenuItem.Name = "modifierLesGroupesToolStripMenuItem";
            this.modifierLesGroupesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.modifierLesGroupesToolStripMenuItem.Text = "modifier les groupes";
            // 
            // AddProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 470);
            this.ControlBox = false;
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProf";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AddProf";
            this.Load += new System.EventHandler(this.AddProf_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.niveauxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGEPdataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matieresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel NivLabel;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox AdresseTb;
        private MetroFramework.Controls.MetroTextBox TelTb;
        private MetroFramework.Controls.MetroTextBox PrenomTb;
        private MetroFramework.Controls.MetroTextBox NomTb;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListView listView1;
        private MetroFramework.Controls.MetroComboBox niveauxcb;
        private MetroFramework.Controls.MetroComboBox matierescb;
        private System.Windows.Forms.Button BtnAddModule;
        private MetroFramework.Controls.MetroButton addbtn;
        private MetroFramework.Controls.MetroButton cancelbtn;
        private Data.OGEPdataSet oGEPdataSet;
        private System.Windows.Forms.BindingSource niveauxBindingSource;
        private Data.OGEPdataSetTableAdapters.NiveauxTableAdapter niveauxTableAdapter;
        private System.Windows.Forms.BindingSource modulesBindingSource;
        private Data.OGEPdataSetTableAdapters.ModulesTableAdapter modulesTableAdapter;
        private System.Windows.Forms.BindingSource matieresBindingSource;
        private Data.OGEPdataSetTableAdapters.MatieresTableAdapter matieresTableAdapter;
        private MetroFramework.Controls.MetroTextBox autreInfo;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroRadioButton nonmonthRb;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroRadioButton monthRb;
        private MetroFramework.Controls.MetroTextBox prixNrml;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MetroFramework.Controls.MetroTextBox prixVip;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox pourcentagetb;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierLesGroupesToolStripMenuItem;
    }
}