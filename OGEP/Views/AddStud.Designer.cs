using OGEP.Data;

namespace OGEP
{
    partial class AddStud
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
            this.BtnAddModule = new System.Windows.Forms.Button();
            this.ModulesList = new System.Windows.Forms.ListView();
            this.NewModuleCb = new MetroFramework.Controls.MetroComboBox();
            this.TelAlterTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.NiveauCb = new MetroFramework.Controls.MetroComboBox();
            this.niveauxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oGEPdbds = new OGEP.Data.OGEPdataSet();
            this.NivLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.AdresseTb = new MetroFramework.Controls.MetroTextBox();
            this.TelTb = new MetroFramework.Controls.MetroTextBox();
            this.PrenomTb = new MetroFramework.Controls.MetroTextBox();
            this.NomTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.confirmBtn = new MetroFramework.Controls.MetroButton();
            this.cancelBtn = new MetroFramework.Controls.MetroButton();
            this.niveauxTableAdapter = new OGEP.Data.OGEPdataSetTableAdapters.NiveauxTableAdapter();
            this.studModuleTableAdapter = new OGEP.Data.OGEPdataSetTableAdapters.StudModuleTableAdapter();
            this.modulesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new OGEP.Data.OGEPdataSetTableAdapters.StudentsTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.niveauxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGEPdbds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.BtnAddModule);
            this.metroPanel1.Controls.Add(this.ModulesList);
            this.metroPanel1.Controls.Add(this.NewModuleCb);
            this.metroPanel1.Controls.Add(this.TelAlterTb);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.NiveauCb);
            this.metroPanel1.Controls.Add(this.NivLabel);
            this.metroPanel1.Controls.Add(this.metroLabel5);
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
            this.metroPanel1.Size = new System.Drawing.Size(358, 338);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // BtnAddModule
            // 
            this.BtnAddModule.BackgroundImage = global::OGEP.Properties.Resources.add_1;
            this.BtnAddModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddModule.Location = new System.Drawing.Point(310, 185);
            this.BtnAddModule.Name = "BtnAddModule";
            this.BtnAddModule.Size = new System.Drawing.Size(29, 29);
            this.BtnAddModule.TabIndex = 23;
            this.BtnAddModule.UseVisualStyleBackColor = true;
            this.BtnAddModule.Click += new System.EventHandler(this.BtnAddModule_Click);
            // 
            // ModulesList
            // 
            this.ModulesList.FullRowSelect = true;
            this.ModulesList.GridLines = true;
            this.ModulesList.Location = new System.Drawing.Point(4, 220);
            this.ModulesList.Name = "ModulesList";
            this.ModulesList.Size = new System.Drawing.Size(351, 115);
            this.ModulesList.TabIndex = 21;
            this.ModulesList.UseCompatibleStateImageBehavior = false;
            this.ModulesList.View = System.Windows.Forms.View.Details;
            this.ModulesList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ModulesList_MouseClick);
            // 
            // NewModuleCb
            // 
            this.NewModuleCb.FormattingEnabled = true;
            this.NewModuleCb.ItemHeight = 23;
            this.NewModuleCb.Location = new System.Drawing.Point(4, 185);
            this.NewModuleCb.Name = "NewModuleCb";
            this.NewModuleCb.Size = new System.Drawing.Size(300, 29);
            this.NewModuleCb.TabIndex = 6;
            this.NewModuleCb.SelectedIndexChanged += new System.EventHandler(this.NewModuleCb_SelectedIndexChanged);
            // 
            // TelAlterTb
            // 
            this.TelAlterTb.Location = new System.Drawing.Point(254, 89);
            this.TelAlterTb.Name = "TelAlterTb";
            this.TelAlterTb.Size = new System.Drawing.Size(83, 23);
            this.TelAlterTb.TabIndex = 4;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(4, 163);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(126, 19);
            this.metroLabel8.TabIndex = 18;
            this.metroLabel8.Text = "Modules | Groupes :";
            // 
            // NiveauCb
            // 
            this.NiveauCb.DataSource = this.niveauxBindingSource;
            this.NiveauCb.DisplayMember = "Description";
            this.NiveauCb.FormattingEnabled = true;
            this.NiveauCb.ItemHeight = 23;
            this.NiveauCb.Location = new System.Drawing.Point(49, 118);
            this.NiveauCb.Name = "NiveauCb";
            this.NiveauCb.Size = new System.Drawing.Size(145, 29);
            this.NiveauCb.Style = MetroFramework.MetroColorStyle.Green;
            this.NiveauCb.TabIndex = 5;
            this.NiveauCb.ValueMember = "Id";
            this.NiveauCb.SelectedIndexChanged += new System.EventHandler(this.NiveauCb_SelectedIndexChanged);
            // 
            // niveauxBindingSource
            // 
            this.niveauxBindingSource.DataMember = "Niveaux";
            this.niveauxBindingSource.DataSource = this.oGEPdbds;
            // 
            // oGEPdbds
            // 
            this.oGEPdbds.DataSetName = "OGEPdbds";
            this.oGEPdbds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NivLabel
            // 
            this.NivLabel.AutoSize = true;
            this.NivLabel.Location = new System.Drawing.Point(4, 125);
            this.NivLabel.Name = "NivLabel";
            this.NivLabel.Size = new System.Drawing.Size(39, 19);
            this.NivLabel.TabIndex = 15;
            this.NivLabel.Text = "Niv : ";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(149, 93);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(99, 19);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "N° tel Parents : ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(4, 93);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "N°Tel : ";
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
            this.metroLabel2.Location = new System.Drawing.Point(165, 17);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Prenom : ";
            // 
            // AdresseTb
            // 
            this.AdresseTb.Location = new System.Drawing.Point(76, 51);
            this.AdresseTb.Name = "AdresseTb";
            this.AdresseTb.Size = new System.Drawing.Size(263, 23);
            this.AdresseTb.TabIndex = 2;
            // 
            // TelTb
            // 
            this.TelTb.Location = new System.Drawing.Point(60, 89);
            this.TelTb.Name = "TelTb";
            this.TelTb.Size = new System.Drawing.Size(83, 23);
            this.TelTb.TabIndex = 3;
            // 
            // PrenomTb
            // 
            this.PrenomTb.Location = new System.Drawing.Point(238, 13);
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
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.oGEPdbds;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(306, 407);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 8;
            this.confirmBtn.Text = "Confirmer";
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(225, 407);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Annuler";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // niveauxTableAdapter
            // 
            this.niveauxTableAdapter.ClearBeforeFill = true;
            // 
            // studModuleTableAdapter
            // 
            this.studModuleTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 26);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // AddStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 440);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStud";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Ajouter un nouvel élève : ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddStud_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.niveauxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGEPdbds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox AdresseTb;
        private MetroFramework.Controls.MetroTextBox TelTb;
        private MetroFramework.Controls.MetroTextBox PrenomTb;
        private MetroFramework.Controls.MetroTextBox NomTb;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox NiveauCb;
        private MetroFramework.Controls.MetroLabel NivLabel;
        private MetroFramework.Controls.MetroButton confirmBtn;
        private MetroFramework.Controls.MetroButton cancelBtn;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox TelAlterTb;
        private OGEPdataSet oGEPdbds;
        private System.Windows.Forms.BindingSource niveauxBindingSource;
        private Data.OGEPdataSetTableAdapters.NiveauxTableAdapter niveauxTableAdapter;
        private Data.OGEPdataSetTableAdapters.StudModuleTableAdapter studModuleTableAdapter;
        private System.Windows.Forms.BindingSource modulesBindingSource1;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private Data.OGEPdataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.ListView ModulesList;
        public MetroFramework.Controls.MetroComboBox NewModuleCb;
        private System.Windows.Forms.Button BtnAddModule;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}